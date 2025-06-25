using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AutoDealership.Infrastructure;
using AutoDealership.Core.Interfaces;
using Auto_Dealership_Management.TestDrive;

namespace Auto_Dealership_Management
{
    public partial class TestDriveForm : Form
    {
        private readonly CarRepository _carRepository = new CarRepository();

        public TestDriveForm()
        {
            InitializeComponent();
            this.Load += TestDriveForm_Load;
            comboBoxBrand.SelectedIndexChanged += comboBoxBrand_SelectedIndexChanged;
        }

        private void TestDriveForm_Load(object sender, EventArgs e)
        {
            PopulateCarBrands();
        }

        private void PopulateCarBrands()
        {
            var cars = _carRepository.GetAllCars();
            var brands = new HashSet<string>();

            foreach (var car in cars)
                brands.Add(car.Make);

            if (brands.Count == 0)
                MessageBox.Show("NU există mărci în baza de date!");
            else
                comboBoxBrand.DataSource = new BindingSource(brands, null);
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBrand.SelectedItem != null)
                PopulateCarModels(comboBoxBrand.SelectedItem.ToString());
        }

        private void PopulateCarModels(string brand)
        {
            var cars = _carRepository.GetAllCars();
            var models = new HashSet<string>();

            foreach (var car in cars)
            {
                if (car.Make == brand)
                    models.Add(car.Model);
            }

            if (models.Count == 0)
                MessageBox.Show($"NU există modele pentru marca {brand}!");
            else
                comboBoxModel.DataSource = new BindingSource(models, null);
        }

        private void btnScheduleTestDrive_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string selectedBrand = comboBoxBrand.SelectedItem?.ToString();
            string selectedModel = comboBoxModel.SelectedItem?.ToString();
            DateTime testDriveDate = dateTimePickerTestDrive.Value;

            if (string.IsNullOrWhiteSpace(customerName) || selectedBrand == null || selectedModel == null)
            {
                MessageBox.Show("Completează toate câmpurile!");
                return;
            }

            TestDriveFactory factory;

            if (selectedBrand == "BMW" || selectedBrand == "Mercedes-Benz" || selectedBrand == "Audi")
                factory = new LuxuryTestDriveFactory();
            else
                factory = new StandardTestDriveFactory();

            ITestDrive testDrive = factory.CreateTestDrive();

            try
            {
                testDrive.Schedule(customerName, selectedBrand, selectedModel, testDriveDate);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la programarea test-drive-ului: " + ex.Message);
            }
        }
    }
}
