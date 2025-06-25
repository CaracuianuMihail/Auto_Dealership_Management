namespace AutoDealership.Core.Interfaces
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal basePrice);
        string Description { get; }
    }
}
