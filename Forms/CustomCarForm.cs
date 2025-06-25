using System;
using System.Windows.Forms;
using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;
using AutoDealership.Infrastructure.Builders;
using AutoDealership.Infrastructure;
using AutoDealership.Core.Entities.CarDecorators;
using AutoDealership.Services;

namespace Auto_Dealership_Management
{
    public partial class CustomCarForm : Form
    {
        private readonly CustomCarRepository _repository = new CustomCarRepository();

        public CustomCarForm()
        {
            InitializeComponent();
        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            var builder = new CustomCarBuilder();
            builder.SetMake(txtMake.Text);
            builder.SetModel(txtModel.Text);
            builder.SetYear((int)numYear.Value);
            builder.SetPrice(decimal.Parse(txtPrice.Text));
            builder.SetKilometers(int.Parse(txtKilometers.Text));
            builder.SetIsElectric(chkElectric.Checked);
            builder.SetColor(txtColor.Text);
            builder.SetInteriorType(txtInterior.Text);
            builder.SetTransmissionType(txtTransmission.Text);
            builder.SetHasSunroof(chkSunroof.Checked);
            builder.SetWheelType(txtWheel.Text);
            builder.SetInfotainmentSystem(txtInfotainment.Text);
            builder.SetAdditionalNotes(txtNotes.Text);

            var car = builder.Build();
            _repository.AddCustomCar(car);

            MessageBox.Show("Mașina personalizată a fost salvată!");
        }

        private void CustomCarForm_Load(object sender, EventArgs e)
        {

        }

        private void txtMake_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void numYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKilometers_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkElectric_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInterior_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTransmission_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSunroof_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtWheel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInfotainment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
