using AutoDealership.Core.Interfaces;

namespace AutoDealership.Core.Services
{
    public class PriceCalculator
    {
        private readonly IDiscountStrategy _strategy;

        public PriceCalculator(IDiscountStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal CalculateFinalPrice(decimal basePrice)
        {
            return _strategy.ApplyDiscount(basePrice);
        }

        public string StrategyDescription => _strategy.Description;
    }
}
