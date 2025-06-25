using AutoDealership.Core.Interfaces;

namespace AutoDealership.Core.DiscountStrategies
{
    public class SeasonalDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal basePrice) => basePrice * 0.9m;
        public string Description => "Reducere sezonieră (10%)";
    }
}
