using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDealership.Core.Interfaces
{
    public interface ITestDrive
    {
        void Schedule(string customerName, string brand, string model, DateTime date);
    }
}
