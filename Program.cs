using System;
using System.Windows.Forms;

namespace Auto_Dealership_Management
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lansează formularul de logare
            Application.Run(new LoginForm());
        }
    }
}
