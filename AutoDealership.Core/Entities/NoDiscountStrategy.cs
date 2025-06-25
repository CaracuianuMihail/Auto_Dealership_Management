using AutoDealership.Core.Interfaces;

namespace AutoDealership.Core.DiscountStrategies
{
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal basePrice) => basePrice;
        public string Description => "Fără reducere";
    }
}
