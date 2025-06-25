using System;
using System.Windows.Forms;

namespace Auto_Dealership_Management
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bine ai venit, Admin!");
        }
    }
}
