using AutoDealership.Core.Interfaces;

namespace Auto_Dealership_Management.TestDrive
{
    public class LuxuryTestDriveFactory : TestDriveFactory
    {
        public override ITestDrive CreateTestDrive()
        {
            return new LuxuryTestDrive();
        }
    }
}
