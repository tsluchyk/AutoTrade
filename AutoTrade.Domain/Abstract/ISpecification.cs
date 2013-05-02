using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using AutoTrade.Domain.Concrete;

namespace AutoTrade.Domain.Abstract
{
    public interface IVehicleSpecification
    {
        IQueryable<Vehicle> SatisfiedBy(IQueryable<Vehicle> vehicles);
    }
}
