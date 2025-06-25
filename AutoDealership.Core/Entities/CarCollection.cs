using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;
using AutoDealership.Core.Iterators;
using System.Collections.Generic;

namespace AutoDealership.Core.Collections
{
    public class CarCollection : ICarCollection
    {
        private readonly List<Car> _cars;

        public CarCollection(List<Car> cars)
        {
            _cars = cars;
        }

        public ICarIterator GetIterator(string makeFilter)
        {
            return new FilteredCarIterator(_cars, makeFilter);
        }
    }
}
