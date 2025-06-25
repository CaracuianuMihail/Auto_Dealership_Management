using AutoDealership.Core.Interfaces;

namespace AutoDealership.Core.DiscountStrategies
{
    public class LoyaltyDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal basePrice) => basePrice * 0.95m;
        public string Description => "Reducere client fidel (5%)";
    }
}
