using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Abstract;

namespace AutoTrade.Domain.Concrete
{
    public class CapacitySpecification:IVehicleSpecification
    {
        private readonly decimal? _capacity;

        public CapacitySpecification(decimal? capacity)
        {
            _capacity = capacity;
        }

        public IQueryable<Vehicle> SatisfiedBy(IQueryable<Vehicle> vehicles)
        {
            return vehicles.Where(v => _capacity == null || v.CubicCapacity == _capacity);
        }
    }
}
