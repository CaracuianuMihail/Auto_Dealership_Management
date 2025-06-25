using AutoDealership.Core.Interfaces;
using AutoDealership.Infrastructure;
using System;
using System.Windows.Forms;

namespace Auto_Dealership_Management.TestDrive
{
    public class StandardTestDrive : ITestDrive
    {
        public void Schedule(string customerName, string brand, string model, DateTime date)
        {
            var repository = new TestDriveRepository();
            repository.ScheduleTestDrive(customerName, brand, model, date, "Standard");

            MessageBox.Show($"[Standard] Test drive programat pentru {customerName} - {brand} {model} pe {date.ToShortDateString()}");
        }
    }
}
