using System;
using System.Linq;
using System.Windows.Forms;
using AutoDealership.Core.Entities;
using AutoDealership.Infrastructure;
using AutoDealership.Core.Interfaces;
using Auto_Dealership_Management.Documents.Standard;
using System.Collections.Generic;
using System.IO;
using Auto_Dealership_Management.Documents.Standard;
using Auto_Dealership_Management.Documents.Luxury;

namespace Auto_Dealership_Management
{
    public partial class ContractForm : Form
    {
        private readonly OrderRepository _orderRepo = new OrderRepository();
        private readonly CustomerRepository _customerRepo = new CustomerRepository();
        private readonly CarRepository _carRepo = new CarRepository();
        private IDocumentFactory _documentFactory;

        private List<Order> _orders;

        public ContractForm()
        {
            InitializeComponent();
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            _orders = _orderRepo.GetAllOrders();
            comboBoxOrder.DataSource = _orders;
            comboBoxOrder.DisplayMember = "Id";
            comboBoxOrder.ValueMember = "Id";
        }

        private void comboBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOrder.SelectedItem is Order selectedOrder)
            {
                var customer = _customerRepo.GetAllCustomers().FirstOrDefault(c => c.Id == selectedOrder.CustomerId);
                var car = _carRepo.GetAllCars().FirstOrDefault(c => c.Id == selectedOrder.CarId);

                txtCustomerName.Text = customer?.FullName ?? "N/A";
                txtCarDetails.Text = car != null ? $"{car.Make} {car.Model} ({car.Year})" : "N/A";
            }
        }

        private void btnGenerateDocs_Click(object sender, EventArgs e)
        {
            var order = comboBoxOrder.SelectedItem as Order;
            if (order == null)
            {
                MessageBox.Show("Selectează o comandă!");
                return;
            }

            var customer = _customerRepo.GetAllCustomers().FirstOrDefault(c => c.Id == order.CustomerId);
            var car = _carRepo.GetAllCars().FirstOrDefault(c => c.Id == order.CarId);

            if (customer == null || car == null)
            {
                MessageBox.Show("Datele nu sunt complete pentru această comandă.");
                return;
            }

            // Selectăm fabrica în funcție de opțiunea aleasă
            var selectedFactory = comboBoxFactory.SelectedItem?.ToString();
            if (selectedFactory == "Luxury")
                _documentFactory = new Auto_Dealership_Management.Documents.Luxury.LuxuryDocumentFactory();
            else
                _documentFactory = new Auto_Dealership_Management.Documents.Standard.StandardDocumentFactory();

            string contractText = _documentFactory.CreateContract().Generate(order, customer, car);
            string invoiceText = _documentFactory.CreateInvoice().Generate(order);
            string offerText = _documentFactory.CreateOffer().Generate(car);

            string fullDocument = $"===== CONTRACT =====\n{contractText}\n\n"
                                + $"===== FACTURĂ =====\n{invoiceText}\n\n"
                                + $"===== OFERTĂ =====\n{offerText}";

            string folderPath = "D:\\UTM\\Anul III\\SEM2\\TMPP\\Contracts";
            Directory.CreateDirectory(folderPath);

            string fileName = $"Contract_{order.Id}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string filePath = Path.Combine(folderPath, fileName);

            File.WriteAllText(filePath, fullDocument);

            MessageBox.Show($"Documentul a fost salvat în:\n{filePath}", "Succes!");
        }


    }
}
