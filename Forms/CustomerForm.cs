using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using AutoDealership.Core.Entities;
using AutoDealership.Infrastructure;

namespace Auto_Dealership_Management
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerRepository _repository = new CustomerRepository();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                FullName = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text
            };

            _repository.AddCustomer(customer);
            LoadCustomers();
            MessageBox.Show("Client adăugat cu succes!");
        }

        private void LoadCustomers()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _repository.GetAllCustomers();
        }

        private void btnGenerateCustomerReport_Click(object sender, EventArgs e)
        {
            // Obținem instanța unică a CustomerReportManager
            CustomerReportManager reportManager = CustomerReportManager.GetInstance();

            // Obținem lista de clienți din baza de date
            CustomerRepository customerRepo = new CustomerRepository();
            List<Customer> customers = customerRepo.GetAllCustomers();

            // Generăm raportul de clienți
            reportManager.GenerateCustomerReport(customers);

            // Afișăm un mesaj de succes
            MessageBox.Show("Raportul de clienți a fost generat!");
        }

    }
}
