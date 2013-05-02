using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Abstract;

namespace AutoTrade.Domain.Concrete
{
    public class VehicleSearchSpecification:IVehicleSpecification
    {
        public string Color { get; set; }
        public decimal? Capacity { get; set; }
        public decimal? LowPrice { get; set; }
        public decimal? HighPrice { get; set; }
        public int? IdAutoModel { get; set; }
        public int? IdBrand { get; set; }


        public IQueryable<Vehicle> SatisfiedBy(IQueryable<Vehicle> vehicles)
        {
            return
                new BrandSpecification(IdBrand).SatisfiedBy(
                    new AutoModelSpecification(IdAutoModel).SatisfiedBy(
                        new ColorVehicleSpecification(Color).SatisfiedBy(
                            new CapacitySpecification(Capacity).SatisfiedBy(
                                new PriceSpecification(LowPrice, HighPrice).SatisfiedBy(vehicles)
                            ))));
        }
    }
}
