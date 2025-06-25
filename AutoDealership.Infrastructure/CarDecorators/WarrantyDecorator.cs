namespace AutoDealership.Core.Entities.CarDecorators
{
    public class WarrantyDecorator : CarDecorator
    {
        public WarrantyDecorator(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return _car.GetDescription() + " + Garanție extinsă";
        }

        public override decimal GetPrice()
        {
            return _car.GetPrice() + 2500m;
        }
    }
}
