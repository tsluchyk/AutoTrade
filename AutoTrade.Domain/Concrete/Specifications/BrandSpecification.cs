using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Abstract;
using System.Linq.Expressions;

namespace AutoTrade.Domain.Concrete
{
    public class BrandSpecification:IVehicleSpecification
    {
        private readonly int? _idBrand;

        public BrandSpecification(int? id)
        {
            _idBrand = id;
        }

        public IQueryable<Vehicle> SatisfiedBy(IQueryable<Vehicle> vehicles)
        {
            var veh= vehicles.Where(v => _idBrand == null || v.AutoModel.IdBrand == _idBrand);
            return veh;
        }
    }
}
