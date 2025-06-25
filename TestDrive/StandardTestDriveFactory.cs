using AutoDealership.Core.Interfaces;

namespace Auto_Dealership_Management.TestDrive
{
    public class StandardTestDriveFactory : TestDriveFactory
    {
        public override ITestDrive CreateTestDrive()
        {
            return new StandardTestDrive();
        }
    }
}
