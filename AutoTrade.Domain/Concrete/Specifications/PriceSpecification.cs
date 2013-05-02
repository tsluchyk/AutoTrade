using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Abstract;

namespace AutoTrade.Domain.Concrete
{
    public class PriceSpecification:IVehicleSpecification
    {
        private readonly decimal? _lowPrice;
        private readonly decimal? _highPrice;

        public PriceSpecification(decimal? lowPrice, decimal? highPrice)
        {
            _lowPrice = lowPrice;
            _highPrice = highPrice;
        }

        public IQueryable<Vehicle> SatisfiedBy(IQueryable<Vehicle> vehicles)
        {
            return vehicles.Where(v => ((_lowPrice == null || v.Price >= _lowPrice) 
                && (_highPrice == null || v.Price <= _highPrice)));
        }
    }
}
