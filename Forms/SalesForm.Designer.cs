using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Auto_Dealership_Management
{
    public partial class SalesForm : Form
    {
        private DoubleBufferedPanel panelSalesMenu;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.SuspendLayout();

            // Setări formular
            this.BackColor = SystemColors.Control;
            this.BackgroundImage = Properties.Resources.image2;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new Size(1474, 450);
            this.DoubleBuffered = true;
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            this.WindowState = FormWindowState.Maximized;
            this.Load += new EventHandler(this.SalesForm_Load);

            // IMPORTANT: construim UI-ul
            InitializeSalesPanel();
            AddSalesTitleLabel();
            AddSalesButtonsCentered();

            this.ResumeLayout(false);
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

        private void InitializeSalesPanel()
        {
            panelSalesMenu = new DoubleBufferedPanel();
            panelSalesMenu.BackColor = Color.FromArgb(180, Color.White);
            panelSalesMenu.Size = new Size(900, 260);
            panelSalesMenu.Left = (this.ClientSize.Width - panelSalesMenu.Width) / 2;
            panelSalesMenu.Top = (this.ClientSize.Height - panelSalesMenu.Height) / 2;

            RoundCorners(panelSalesMenu, 30);
            this.Controls.Add(panelSalesMenu);

            this.Resize += (s, e) =>
            {
                int newLeft = (this.ClientSize.Width - panelSalesMenu.Width) / 2;
                int newTop = (this.ClientSize.Height - panelSalesMenu.Height) / 2;
                panelSalesMenu.Left = newLeft;
                panelSalesMenu.Top = newTop;
            };
        }

        private void AddSalesTitleLabel()
        {
            PictureBox logo = new PictureBox();
            logo.Image = Properties.Resources.sales;
            logo.Size = new Size(40, 40);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.BackColor = Color.Transparent;

            Label lblTitle = new Label();
            lblTitle.Text = "Panou de Vânzări";
            lblTitle.Font = new Font("Cascadia Code", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.AutoSize = true;

            int totalWidth = logo.Width + 10 + TextRenderer.MeasureText(lblTitle.Text, lblTitle.Font).Width;
            int startX = (panelSalesMenu.Width - totalWidth) / 2;

            logo.Location = new Point(startX, 20);
            lblTitle.Location = new Point(logo.Right + 10, 25);

            panelSalesMenu.Controls.Add(logo);
            panelSalesMenu.Controls.Add(lblTitle);
        }

        private void AddSalesButtonsCentered()
        {
            int buttonWidth = 260;
            int buttonHeight = 50;
            int spacing = 30;
            int totalWidth = (buttonWidth * 3) + (spacing * 2);
            int startX = (panelSalesMenu.Width - totalWidth) / 2;
            int y = 120;

            // Test Drive
            var btnTestDrive = new Button();
            btnTestDrive.Text = "     Test Drive";
            btnTestDrive.Size = new Size(buttonWidth, buttonHeight);
            btnTestDrive.Location = new Point(startX, y);
            btnTestDrive.Font = new Font("Cascadia Code", 10F, FontStyle.Bold);
            btnTestDrive.Image = ResizeImage(Properties.Resources.driving_test, 20, 20);
            btnTestDrive.ImageAlign = ContentAlignment.MiddleLeft;
            btnTestDrive.TextAlign = ContentAlignment.MiddleCenter;
            btnTestDrive.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTestDrive.FlatStyle = FlatStyle.Flat;
            btnTestDrive.FlatAppearance.BorderSize = 1;
            btnTestDrive.Click += btnTestDrive_Click;
            panelSalesMenu.Controls.Add(btnTestDrive);

            // Contract
            var btnContract = new Button();
            btnContract.Text = "     Generare Contract";
            btnContract.Size = new Size(buttonWidth, buttonHeight);
            btnContract.Location = new Point(startX + buttonWidth + spacing, y);
            btnContract.Font = new Font("Cascadia Code", 10F, FontStyle.Bold);
            btnContract.Image = ResizeImage(Properties.Resources.contract_agreement, 20, 20);
            btnContract.ImageAlign = ContentAlignment.MiddleLeft;
            btnContract.TextAlign = ContentAlignment.MiddleCenter;
            btnContract.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnContract.FlatStyle = FlatStyle.Flat;
            btnContract.FlatAppearance.BorderSize = 1;
            btnContract.Click += btnContractForm_Click;
            panelSalesMenu.Controls.Add(btnContract);

            // Mașină personalizată
            var btnCustomCar = new Button();
            btnCustomCar.Text = "     Mașină Personalizată";
            btnCustomCar.Size = new Size(buttonWidth, buttonHeight);
            btnCustomCar.Location = new Point(startX + (buttonWidth + spacing) * 2, y);
            btnCustomCar.Font = new Font("Cascadia Code", 10F, FontStyle.Bold);
            btnCustomCar.Image = ResizeImage(Properties.Resources.customization, 20, 20);
            btnCustomCar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomCar.TextAlign = ContentAlignment.MiddleCenter;
            btnCustomCar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomCar.FlatStyle = FlatStyle.Flat;
            btnCustomCar.FlatAppearance.BorderSize = 1;
            btnCustomCar.Click += btnCustomCar_Click;
            panelSalesMenu.Controls.Add(btnCustomCar);
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
