namespace AutoDealership.Core.Entities.CarDecorators
{
    public class AudioDecorator : CarDecorator
    {
        public AudioDecorator(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return _car.GetDescription() + " + Sistem audio premium";
        }

        public override decimal GetPrice()
        {
            return _car.GetPrice() + 1800m;
        }
    }
}
