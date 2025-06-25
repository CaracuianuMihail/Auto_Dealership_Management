using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AutoDealership.Core.Commands;
using AutoDealership.Core.DiscountStrategies;
using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;
using AutoDealership.Core.Services;
using AutoDealership.Infrastructure;

namespace Auto_Dealership_Management
{
    public partial class OrderForm : Form
    {
        private readonly OrderRepository _orderRepository = new OrderRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadCars();

            dgvOrders.AutoGenerateColumns = true;
            cbCars.SelectedIndexChanged += cbCars_SelectedIndexChanged;

            LoadOrders();

            cmbDiscountType.Items.Add("Fără reducere");
            cmbDiscountType.Items.Add("Client fidel");
            cmbDiscountType.Items.Add("Sezonieră");
            cmbDiscountType.SelectedIndex = 0;
        }


        private void LoadCustomers()
        {
            var customers = _customerRepository.GetAllCustomers();
            cmbCustomers.DataSource = customers;
            cmbCustomers.DisplayMember = "FullName";
            cmbCustomers.ValueMember = "Id";
        }

        private void LoadOrders()
        {
            dgvOrders.DataSource = null;

            var orders = _orderRepository.GetAllOrders();

            dgvOrders.DataSource = orders.Select(o => new
            {
                o.Id,
                o.CustomerId,
                o.CarId,
                o.TotalPrice,
                o.OrderDate,
                o.DiscountType,
                o.OrderState
            }).ToList();
        }
        private readonly CarRepository _carRepository = new CarRepository();
        private List<Car> _allCars;

        private void LoadCars()
        {
            _allCars = _carRepository.GetAllCars();

            var carList = _allCars
                .Select(car => new
                {
                    car.Id,
                    Name = $"{car.Make} {car.Model} {car.Year}"
                })
                .ToList();

            cbCars.DataSource = carList;
            cbCars.DisplayMember = "Name";
            cbCars.ValueMember = "Id";
        }
        private void cbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCars.SelectedValue != null)
            {
                int selectedCarId = Convert.ToInt32(cbCars.SelectedValue);
                var selectedCar = _allCars.FirstOrDefault(c => c.Id == selectedCarId);

                if (selectedCar != null)
                {
                    txtBasePrice.Text = selectedCar.Price.ToString("0.00");
                }
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvOrders.Rows[e.RowIndex];
                string discountType = row.Cells["DiscountType"].Value?.ToString() ?? "Nespecificat";
                lblDiscountType.Text = $"Reducere: {discountType}";
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedItem is Customer selectedCustomer && decimal.TryParse(txtTotal.Text, out decimal total))
            {
                string selectedDiscount = cmbDiscountType.SelectedItem?.ToString() ?? "Nespecificat";

                var order = new Order
                {
                    CustomerId = selectedCustomer.Id,
                    CarId = Convert.ToInt32(cbCars.SelectedValue),
                    TotalPrice = total,
                    OrderDate = DateTime.Now,
                    DiscountType = selectedDiscount
                };

                var command = new PlaceOrderCommand(_orderRepository, order);
                command.Execute();

                LoadOrders();
                MessageBox.Show("Comandă plasată cu succes!");
            }
            else
            {
                MessageBox.Show("Date invalide!");
            }
        }

        private void btnCalcDiscount_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtBasePrice.Text, out decimal basePrice))
            {
                MessageBox.Show("Introduceți un preț valid.");
                return;
            }

            IDiscountStrategy strategy;

            switch (cmbDiscountType.SelectedItem.ToString())
            {
                case "Client fidel":
                    strategy = new LoyaltyDiscountStrategy();
                    break;
                case "Sezonieră":
                    strategy = new SeasonalDiscountStrategy();
                    break;
                default:
                    strategy = new NoDiscountStrategy();
                    break;
            }

            var calculator = new PriceCalculator(strategy);
            var finalPrice = calculator.CalculateFinalPrice(basePrice);

            txtDiscountPrice.Text = finalPrice.ToString("0.00");
            txtTotal.Text = finalPrice.ToString("0.00");
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Selectează o comandă din listă.");
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.CurrentRow.Cells["Id"].Value);

            var confirm = MessageBox.Show("Ești sigur că vrei să ștergi această comandă?", "Confirmare", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            var deleteCommand = new DeleteOrderCommand(_orderRepository, orderId);
            deleteCommand.Execute();

            LoadOrders();
            MessageBox.Show("Comanda a fost ștearsă cu succes.");
        }

        private void btnAdvanceState_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Selectează o comandă.");
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.CurrentRow.Cells["Id"].Value);

            var order = _orderRepository.GetAllOrders().FirstOrDefault(o => o.Id == orderId);

            if (order != null)
            {
                order.AdvanceState();
                lblCurrentState.Text = $"Stare: {order.GetStateName()}";

                MessageBox.Show("Comanda a fost avansată în starea următoare.");

                _orderRepository.UpdateOrderState(order.Id, order.GetStateName());

                LoadOrders();
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
