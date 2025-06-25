using System;
using System.Windows.Forms;
using AutoDealership.Core.Entities;
using AutoDealership.Infrastructure;
using System.IO;
using System.Drawing;
using AutoDealership.Services;
using AutoDealership.Infrastructure.Flyweights;
using System.Linq;
using AutoDealership.Core.Entities.CarDecorators;
using AutoDealership.Core.Collections;
using AutoDealership.Core.Interfaces;
using System.Collections.Generic;

namespace Auto_Dealership_Management
{
    public partial class CarForm : Form
    {
        private readonly CarService _carService = new CarService();
        private int selectedCarIndex = -1;
        private string selectedImagePath = "";

        public CarForm()
        {
            InitializeComponent();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            var carsFromDb = new CarRepository().GetAllCars();
            _carService.LoadFromDb(carsFromDb);
            LoadCars();
        }

        private void LoadCars()
        {
            dgvCars.DataSource = _carService.GetAllCars().Select((car, index) => new
            {
                Index = index,
                Make = car.Flyweight.Make,
                Model = car.Flyweight.Model,
                Color = car.Flyweight.Color,
                car.Year,
                car.Price,
                car.Kilometers,
                car.IsAvailable,
                car.ImagePath
            }).ToList();
        }


        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMake.Text) || string.IsNullOrWhiteSpace(txtModel.Text) || string.IsNullOrWhiteSpace(txtColor.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtKilometers.Text))
            {
                MessageBox.Show("Completează toate câmpurile obligatorii.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Prețul trebuie să fie un număr valid.");
                return;
            }

            if (!int.TryParse(txtKilometers.Text, out int kilometers))
            {
                MessageBox.Show("Kilometrii trebuie să fie un număr valid.");
                return;
            }

            var car = new Car
            {
                Make = txtMake.Text,
                Model = txtModel.Text,
                Year = (int)numYear.Value,
                Price = price,
                IsAvailable = chkAvailable.Checked,
                Kilometers = kilometers,
                ImagePath = selectedImagePath
            };

            _carService.AddCar(
                txtMake.Text,
                txtModel.Text,
                txtColor.Text, 
                (int)numYear.Value,
                price,
                int.Parse(txtKilometers.Text),
                chkAvailable.Checked,
                selectedImagePath
            );
            LoadCars();
            ClearInputs();
            MessageBox.Show("Mașină adăugată cu succes!");
        }

        private void ClearInputs()
        {
            txtMake.Clear();
            txtModel.Clear();
            txtColor.Clear();
            txtPrice.Clear();
            txtKilometers.Clear();
            numYear.Value = 2020;
            chkAvailable.Checked = false;
            selectedImagePath = "";
        }
        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCars.Rows[e.RowIndex];

                selectedCarIndex = Convert.ToInt32(row.Cells["Index"].Value);
                txtMake.Text = row.Cells["Make"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                txtColor.Text = row.Cells["Color"].Value?.ToString() ?? "";
                numYear.Value = Convert.ToDecimal(row.Cells["Year"].Value);
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                chkAvailable.Checked = (bool)row.Cells["IsAvailable"].Value;
                txtKilometers.Text = row.Cells["Kilometers"].Value.ToString();

                try
                {
                    string imagePath = row.Cells["ImagePath"].Value?.ToString();
                    selectedImagePath = imagePath;

                    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    {
                        ICarImage image = new CarImageProxy(imagePath);
                        pictureBoxCar.Image = image.GetImage();
                    }
                    else
                    {
                        pictureBoxCar.Image = null;
                    }
                }
                catch
                {
                    pictureBoxCar.Image = null;
                }
            }
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            if (selectedCarIndex == -1)
            {
                MessageBox.Show("Selectează o mașină din listă pentru editare.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal basePrice))
            {
                MessageBox.Show("Prețul trebuie să fie un număr valid.");
                return;
            }

            if (!int.TryParse(txtKilometers.Text, out int kilometers))
            {
                MessageBox.Show("Kilometrii trebuie să fie un număr valid.");
                return;
            }

            // Obține obiectul original din baza de date
            var carRepo = new CarRepository();
            var allCars = carRepo.GetAllCars();

            if (selectedCarIndex >= allCars.Count)
            {
                MessageBox.Show("Index invalid.");
                return;
            }

            var car = allCars[selectedCarIndex];

            // Actualizează câmpurile
            car.Make = txtMake.Text;
            car.Model = txtModel.Text;
            car.Color = txtColor.Text;
            car.Year = (int)numYear.Value;
            car.Kilometers = kilometers;
            car.Price = basePrice; // prețul de bază
            car.IsAvailable = chkAvailable.Checked;
            car.ImagePath = selectedImagePath;

            // Construiește decorarea pentru calculul prețului total
            var flyweight = new CarFlyweight(car.Make, car.Model, car.Color ?? "Default");

            var carContext = new CarContext(flyweight, car.Year, car.Price, car.Kilometers, car.IsAvailable, car.ImagePath);
            ICar decoratedCar = new BaseCar(carContext);

            if (chkWarranty.Checked)
                decoratedCar = new WarrantyDecorator(decoratedCar);

            if (chkAudio.Checked)
                decoratedCar = new AudioDecorator(decoratedCar);

            // Actualizează prețul final în obiectul Car
            car.Price = decoratedCar.GetPrice();

            // Salvează în DB
            carRepo.UpdateCar(car);

            LoadCars();
            ClearInputs();
            MessageBox.Show("Mașina a fost actualizată și decorarea a fost salvată!");
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (selectedCarIndex == -1)
            {
                MessageBox.Show("Selectează o mașină din listă pentru ștergere.");
                return;
            }

            var confirmResult = MessageBox.Show("Sigur vrei să ștergi această mașină?", "Confirmare ștergere", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                _carService.RemoveCarByIndex(selectedCarIndex);
                LoadCars();
                ClearInputs();
                MessageBox.Show("Mașina a fost ștearsă!");
            }
        }


        private void btnExportCars_Click(object sender, EventArgs e)
        {
            var cars = _carService.GetAllCars()
                .Select(c => new CarExportModel
                {
                    Make = c.Flyweight.Make,
                    Model = c.Flyweight.Model,
                    Color = c.Flyweight.Color,
                    Year = c.Year,
                    Price = c.Price,
                    Kilometers = c.Kilometers,
                    IsAvailable = c.IsAvailable,
                    ImagePath = c.ImagePath
                })
                .ToList();

            var exporter = new CarCsvAdapter(new CsvExporter());

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "ExportCars.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exporter.ExportCars(cars, saveFileDialog.FileName);
                MessageBox.Show("Export realizat cu succes!");
            }
        }


        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selectează o imagine";
            ofd.Filter = "Fișiere imagine (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                try
                {
                    ICarImage image = new CarImageProxy(selectedImagePath);
                    pictureBoxCar.Image = image.GetImage();
                }
                catch
                {
                    MessageBox.Show("Nu s-a putut încărca imaginea.");
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (selectedCarIndex == -1)
            {
                MessageBox.Show("Selectează o mașină mai întâi.");
                return;
            }

            var carContext = _carService.GetCarByIndex(selectedCarIndex);
            ICar car = new BaseCar(carContext);

            if (chkWarranty.Checked)
                car = new WarrantyDecorator(car);

            if (chkAudio.Checked)
                car = new AudioDecorator(car);

            txtFinalDescription.Text = car.GetDescription();
            txtFinalPrice.Text = car.GetPrice().ToString("0.00") + " EUR";
        }

        private void btnFilterCars_Click(object sender, EventArgs e)
        {
            string makeFilter = txtFilterMake.Text.Trim();

            if (string.IsNullOrWhiteSpace(makeFilter))
            {
                MessageBox.Show("Introduceți o marcă pentru filtrare.");
                return;
            }
            var carsFromDb = new CarRepository().GetAllCars();
            var collection = new CarCollection(carsFromDb);

            ICarIterator iterator = collection.GetIterator(makeFilter);

            var filteredCars = new List<Car>();
            while (iterator.HasNext())
            {
                filteredCars.Add(iterator.Next());
            }

            dgvCars.DataSource = null;
            dgvCars.DataSource = filteredCars.Select(c => new
            {
                c.Id,
                c.Make,
                c.Model,
                c.Color,
                c.Year,
                c.Price,
                c.Kilometers,
                c.IsAvailable,
                c.ImagePath
            }).ToList();
        }
    }
}
