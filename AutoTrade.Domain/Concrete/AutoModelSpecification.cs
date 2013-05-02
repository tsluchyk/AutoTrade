using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Abstract;
using System.Linq.Expressions;

namespace AutoTrade.Domain.Concrete
{
    public class AutoModelSpecification:IVehicleSpecification
    {
        private readonly int? _idAutoModel;

        public AutoModelSpecification(int? id)
        {
            _idAutoModel = id;
        }

        public IQueryable<Vehicle> SatisfiedBy(IQueryable<Vehicle> vehicles)
        {
            return vehicles.Where(v=> _idAutoModel==null || v.IdAutoModel==_idAutoModel);
        }
    }
}
