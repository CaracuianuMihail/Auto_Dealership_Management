using System.Collections.Generic;

namespace AutoDealership.Infrastructure.Flyweights
{
    public class CarFlyweightFactory
    {
        private readonly Dictionary<string, CarFlyweight> _flyweights = new Dictionary<string, CarFlyweight>();

        public CarFlyweight GetFlyweight(string make, string model, string color)
        {
            string key = $"{make}_{model}_{color}";

            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new CarFlyweight(make, model, color);
            }

            return _flyweights[key];
        }

        public int Count => _flyweights.Count;
    }
}
