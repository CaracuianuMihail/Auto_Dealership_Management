using System;
using System.Drawing;
using System.Windows.Forms;

namespace Auto_Dealership_Management
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
            AddLogoutButton();
        }
        
        private Button btnLogout;

        private void AddLogoutButton()
        {
            btnLogout = new Button();
            btnLogout.Text = "Deconectare";
            btnLogout.Font = new Font("Cascadia Code", 10F, FontStyle.Bold);
            btnLogout.Size = new Size(120, 35);
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(this.ClientSize.Width - btnLogout.Width - 20, 20);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 1;
            btnLogout.Click += BtnLogout_Click;

            this.Controls.Add(btnLogout);

            this.Resize += (s, e) =>
            {
                btnLogout.Location = new Point(this.ClientSize.Width - btnLogout.Width - 20, 20);
            };
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }


        private void SalesForm_Load(object sender, EventArgs e)
        {
        }

        private void btnTestDrive_Click(object sender, EventArgs e)
        {
            TestDriveForm testDriveForm = new TestDriveForm();
            testDriveForm.ShowDialog();
        }

        private void btnContractForm_Click(object sender, EventArgs e)
        {
            ContractForm form = new ContractForm();
            form.ShowDialog();
        }

        private void btnCustomCar_Click(object sender, EventArgs e)
        {
            CustomCarForm form = new CustomCarForm();
            form.ShowDialog();
        }
    }
}
