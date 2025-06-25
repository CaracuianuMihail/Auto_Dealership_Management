using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Dealership_Management
{
    public partial class LoginForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();

            // Anti-flicker global
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterPanel();
            panelCenter.BackColor = Color.FromArgb(180, Color.White);
            RoundCorners(panelCenter, 25);

            // Tab Order
            txtUsername.TabIndex = 0;
            txtPassword.TabIndex = 1;
            btnLogin.TabIndex = 2;

            // Enter = Logare
            this.AcceptButton = btnLogin;

            // Focus inițial
            txtUsername.Focus();

            // Anti-flicker aplicat din nou (extra safety)
            panelCenter.GetType().GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(panelCenter, true, null);
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            int newLeft = (this.ClientSize.Width - panelCenter.Width) / 2;
            int newTop = (this.ClientSize.Height - panelCenter.Height) / 2;

            if (panelCenter.Left != newLeft || panelCenter.Top != newTop)
            {
                panelCenter.Left = newLeft;
                panelCenter.Top = newTop;
            }
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            btnLogin.Cursor = Cursors.WaitCursor;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Login asincron
            string role = await Task.Run(() => AuthenticateUser(username, password));

            btnLogin.Enabled = true;
            btnLogin.Cursor = Cursors.Default;

            if (role != null)
            {
                this.Hide();

                if (role == "Admin")
                {
                    new Form1().ShowDialog();
                }
                else if (role == "Sales")
                {
                    new SalesForm().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Rol necunoscut.");
                }
            }
            else
            {
                MessageBox.Show("Numele de utilizator sau parola sunt incorecte.");
            }
        }

        private string AuthenticateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    var role = cmd.ExecuteScalar();
                    return role?.ToString();
                }
            }
        }
    }
}
