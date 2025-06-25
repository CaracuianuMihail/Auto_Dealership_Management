using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Auto_Dealership_Management
{
    public partial class Form1 : Form
    {
        private DoubleBufferedPanel panelMenu;

        public Form1()
        {
            InitializeComponent();

            // Prevenire flicker global
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();

            InitializeMenuPanel();
            AddTitleLabelInsidePanel();
            AddMenuButtonsCentered();
            AddLogoutButton();
        }

        public class DoubleBufferedPanel : Panel
        {
            public DoubleBufferedPanel()
            {
                this.DoubleBuffered = true;
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
                this.UpdateStyles();
            }
        }

        private void InitializeMenuPanel()
        {
            panelMenu = new DoubleBufferedPanel();
            panelMenu.BackColor = Color.FromArgb(180, Color.White);
            panelMenu.Size = new Size(800, 250);
            panelMenu.Left = (this.ClientSize.Width - panelMenu.Width) / 2;
            panelMenu.Top = (this.ClientSize.Height - panelMenu.Height) / 2;

            RoundCorners(panelMenu, 30);
            this.Controls.Add(panelMenu);

            this.Resize += (s, e) =>
            {
                int newLeft = (this.ClientSize.Width - panelMenu.Width) / 2;
                int newTop = (this.ClientSize.Height - panelMenu.Height) / 2;

                if (panelMenu.Left != newLeft || panelMenu.Top != newTop)
                {
                    panelMenu.Left = newLeft;
                    panelMenu.Top = newTop;
                }
            };
        }

        private void AddTitleLabelInsidePanel()
        {
            PictureBox logo = new PictureBox();
            logo.Image = Properties.Resources.admin_panel;
            logo.Size = new Size(40, 40);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.BackColor = Color.Transparent;

            Label lblTitle = new Label();
            lblTitle.Text = "Panou de control AutoDealership";
            lblTitle.Font = new Font("Cascadia Code", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.AutoSize = true;

            int totalWidth = logo.Width + 10 + TextRenderer.MeasureText(lblTitle.Text, lblTitle.Font).Width;
            int startX = (panelMenu.Width - totalWidth) / 2;

            logo.Location = new Point(startX, 20);
            lblTitle.Location = new Point(logo.Right + 10, 25);

            panelMenu.Controls.Add(logo);
            panelMenu.Controls.Add(lblTitle);
        }

        private void AddMenuButtonsCentered()
        {
            int buttonWidth = 220;
            int buttonHeight = 50;
            int spacing = 20;
            int totalWidth = (buttonWidth * 3) + (spacing * 2);
            int startX = (panelMenu.Width - totalWidth) / 2;
            int y = 120;

            // --- Clienți ---
            var btnCustomers = new Button();
            btnCustomers.Text = "Gestionare Clienți";
            btnCustomers.Size = new Size(buttonWidth, buttonHeight);
            btnCustomers.Location = new Point(startX, y);
            btnCustomers.Font = new Font("Cascadia Code", 10F, FontStyle.Bold);
            btnCustomers.Image = ResizeImage(Properties.Resources.customer, 20, 20);
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.TextAlign = ContentAlignment.MiddleRight;
            btnCustomers.Padding = new Padding(10, 0, 10, 0);
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.FlatAppearance.BorderSize = 1;
            btnCustomers.Click += BtnCustomers_Click;
            panelMenu.Controls.Add(btnCustomers);

            // --- Comenzi ---
            var btnOrders = new Button();
            btnOrders.Text = "Gestionare Comenzi";
            btnOrders.Size = new Size(buttonWidth, buttonHeight);
            btnOrders.Location = new Point(startX + buttonWidth + spacing, y);
            btnOrders.Font = new Font("Cascadia Code", 10F, FontStyle.Bold);
            btnOrders.Image = ResizeImage(Properties.Resources.checklist, 20, 20);
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextAlign = ContentAlignment.MiddleRight;
            btnOrders.Padding = new Padding(10, 0, 10, 0);
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.FlatAppearance.BorderSize = 1;
            btnOrders.Click += BtnOrders_Click;
            panelMenu.Controls.Add(btnOrders);

            // --- Mașini ---
            var btnCars = new Button();
            btnCars.Text = "Gestionare Mașini";
            btnCars.Size = new Size(buttonWidth, buttonHeight);
            btnCars.Location = new Point(startX + (buttonWidth + spacing) * 2, y);
            btnCars.Font = new Font("Cascadia Code", 10F, FontStyle.Bold);
            btnCars.Image = ResizeImage(Properties.Resources.car, 20, 20);
            btnCars.ImageAlign = ContentAlignment.MiddleLeft;
            btnCars.TextAlign = ContentAlignment.MiddleRight;
            btnCars.Padding = new Padding(10, 0, 10, 0);
            btnCars.FlatStyle = FlatStyle.Flat;
            btnCars.FlatAppearance.BorderSize = 1;
            btnCars.Click += BtnCars_Click;
            panelMenu.Controls.Add(btnCars);
        }

        private Button btnLogout;

        private void AddLogoutButton()
        {
            btnLogout = new Button();
            btnLogout.Text = "Deconectare";
            btnLogout.Font = new Font("Cascadia Code", 8F, FontStyle.Bold);
            btnLogout.Size = new Size(120, 35);
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(this.ClientSize.Width - btnLogout.Width - 20, 20);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 1;
            btnLogout.Click += BtnLogout_Click;

            this.Controls.Add(btnLogout);

            // actualizare poziție la redimensionare
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


        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            new CustomerForm().ShowDialog();
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            new OrderForm().ShowDialog();
        }

        private void BtnCars_Click(object sender, EventArgs e)
        {
            new CarForm().ShowDialog();
        }

        private void RoundCorners(Control control, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            control.Region = new Region(path);
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return bmp;
        }
    }
}
    