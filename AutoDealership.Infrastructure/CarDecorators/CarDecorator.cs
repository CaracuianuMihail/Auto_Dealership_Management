namespace AutoDealership.Core.Entities.CarDecorators
{
    public abstract class CarDecorator : ICar
    {
        protected ICar _car;

        protected CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public virtual decimal GetPrice()
        {
            return _car.GetPrice();
        }
    }
}
