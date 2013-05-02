using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Abstract;
using System.Linq.Expressions;

namespace AutoTrade.Domain.Concrete
{
    public class ColorVehicleSpecification:IVehicleSpecification
    {
        private readonly string _color;

        public ColorVehicleSpecification(string color)
        {
            _color = color;
        }

        public IQueryable<Vehicle>  SatisfiedBy(IQueryable<Vehicle> vehicles)
        {
            return vehicles.Where(v => _color==null || v.Color.StartsWith(_color));
        }
    }
}
