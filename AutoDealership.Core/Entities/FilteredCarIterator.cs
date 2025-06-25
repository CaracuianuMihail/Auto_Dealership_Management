using AutoDealership.Core.Entities;
using AutoDealership.Core.Interfaces;
using System.Collections.Generic;

namespace AutoDealership.Core.Iterators
{
    public class FilteredCarIterator : ICarIterator
    {
        private readonly List<Car> _cars;
        private readonly string _makeFilter;
        private int _position = 0;

        public FilteredCarIterator(List<Car> cars, string makeFilter)
        {
            _makeFilter = makeFilter.ToLower();
            _cars = cars.FindAll(c => c.Make.ToLower().Contains(_makeFilter));
        }

        public bool HasNext()
        {
            return _position < _cars.Count;
        }

        public Car Next()
        {
            return _cars[_position++];
        }
    }
}
