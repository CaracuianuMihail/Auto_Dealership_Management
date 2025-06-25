using AutoDealership.Core.Entities;

namespace AutoDealership.Core.Interfaces
{
    public interface IOffer
    {
        string Generate(Car car);
    }
}