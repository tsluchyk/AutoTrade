using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Abstract;
using System.Linq.Expressions;

namespace AutoTrade.Domain.Concrete
{
    public class VehiclesSummaryRepository: IVehiclesSummaryRepository
    {
        private AutoTradeEntities context = new AutoTradeEntities();

        public IQueryable<VehiclesSummary> VehiclesSummary
        {
            get 
            {
                var vehicles = from v in context.Vehicles
                               select new VehiclesSummary
                               {
                                   Id = v.Id,
                                   Brand = v.AutoModel.Brand.Name,
                                   AutoModel = v.AutoModel.Name,
                                   Color = v.Color,
                                   CubicCapacity = v.CubicCapacity,
                                   Price = v.Price,
                                   Description = v.Description
                               };
                                   
                return vehicles;
            }
        }

        private readonly IDictionary<string, Func< IQueryable<VehiclesSummary>, bool, IOrderedQueryable<VehiclesSummary>>>
            _vehicleOrderings = new Dictionary<string, Func<IQueryable<VehiclesSummary>, bool, IOrderedQueryable<VehiclesSummary>>>
                                    {
                                        {"Brand", CreateOrderingFunc<VehiclesSummary, string>(v=>v.Brand)},
                                        {"AutoModel", CreateOrderingFunc<VehiclesSummary, string>(v=>v.AutoModel)},
                                        {"Color", CreateOrderingFunc<VehiclesSummary, string>(v=>v.Color)},
                                        {"CubicCapacity", CreateOrderingFunc<VehiclesSummary, decimal>(v=>v.CubicCapacity)},
                                        {"Price", CreateOrderingFunc<VehiclesSummary, decimal>(v=>v.Price)}
                                    };

        private static Func<IQueryable<T>, bool, IOrderedQueryable<T>> CreateOrderingFunc<T, TKey>(Expression<Func<T, TKey>> keySelector)
        {
            return
                (source, ascending) =>
                ascending
                    ? source.OrderBy(keySelector)
                    : source.OrderByDescending(keySelector);
        }

        
        public IQueryable<VehiclesSummary> GetSequenceVehicles(out int totalItems,
                                                                int itemPerPage,
                                                                int pageIndex, 
                                                                string sort,
                                                                _SortDirection sortOrder)
        {
            totalItems = context.Vehicles.Count();

            var vehicles = from v in context.Vehicles
                           select new VehiclesSummary
                           {
                               Id = v.Id,
                               Brand = v.AutoModel.Brand.Name,
                               AutoModel = v.AutoModel.Name,
                               Color = v.Color,
                               CubicCapacity = v.CubicCapacity,
                               Price = v.Price,
                               Description = v.Description
                           };

            Func<IQueryable<VehiclesSummary>, bool, IOrderedQueryable<VehiclesSummary>> applyOrdering = _vehicleOrderings[sort];
            vehicles = applyOrdering(vehicles, sortOrder == _SortDirection.Ascending);
            if (itemPerPage > 0 && pageIndex >= 0)
            {
                vehicles = vehicles.Skip(pageIndex * itemPerPage).Take(itemPerPage);
            }

            return vehicles;
        }

        public IQueryable<VehiclesSummary> GetExtensionSequenceVehicles(out int totalItems,
                                                                        int itemPerPage = -1,
                                                                        int pageIndex = -1,
                                                                        string sort = "Brand",
                                                                        _SortDirection sortOrder = _SortDirection.Ascending,
                                                                        string color = null,
                                                                        decimal? capacity = null,
                                                                        decimal? minPrice = null,
                                                                        decimal? maxPrice = null,
                                                                        int? idAutoModel = null,
                                                                        int? idBrand = null)
        {
            totalItems = context.Vehicles.Count();

            var vehicles = new VehicleSearchSpecification() 
            {
                Color = color,
                Capacity=capacity,
                LowPrice=minPrice,
                HighPrice=maxPrice,
                IdAutoModel=idAutoModel,
                IdBrand=idBrand
            }.SatisfiedBy(context.Vehicles);


            //var vehicles = new ColorVehicleSpecification(color).SatisfiedBy(
            //                new CapacitySpecification(capacity).SatisfiedBy(
            //                    new PriceSpecification(minPrice,maxPrice).SatisfiedBy(context.Vehicles)));

            var vehiclesSummary = from v in vehicles
                                  select new VehiclesSummary
                                  {
                                      Id = v.Id,
                                      Brand = v.AutoModel.Brand.Name,
                                      AutoModel = v.AutoModel.Name,
                                      Color = v.Color,
                                      CubicCapacity = v.CubicCapacity,
                                      Price = v.Price,
                                      Description = v.Description
                                  };

            Func<IQueryable<VehiclesSummary>, bool, IOrderedQueryable<VehiclesSummary>> applyOrdering = _vehicleOrderings[sort];
            vehiclesSummary = applyOrdering(vehiclesSummary, sortOrder == _SortDirection.Ascending);
            if (itemPerPage > 0 && pageIndex >= 0)
            {
                vehiclesSummary = vehiclesSummary.Skip(pageIndex * itemPerPage).Take(itemPerPage);
            }
            return vehiclesSummary;
        }


        public IQueryable<string> GetUniqueColors(string colorLetters, int maxCount)
        {
            var colors = (from v in context.Vehicles
                          where v.Color.Contains(colorLetters)
                          select v.Color).Distinct().Take(maxCount);
            return colors;
        }

        public IQueryable<string> GetUniqueCapacity(string capacityLetters, int maxCount)
        {
            var capacities = (from v in context.Vehicles
                              select v.CubicCapacity).Distinct();
            List<string> cap = new List<string>();
            foreach (var c in capacities)
            {
                if (c.ToString().Contains(capacityLetters))
                    cap.Add(c.ToString());

            }
            return cap.AsQueryable();

        }

        //public IQueryable<decimal> GetUniqueCapacity(decimal capacityLetters, int maxCount)
        //{
        //    //string str=capacityLetters.ToString();
        //    var capacities = (from v in context.Vehicles
        //                     select v.CubicCapacity).Distinct();
        //    //var capacities = (from v in context.Vehicles
        //    //                  let cap=v.CubicCapacity.ToString()
        //    //                  where (cap.StartsWith(str))
        //    //                  select v.CubicCapacity).Distinct().Take(maxCount);

        //    //return capacities;

        //    List<decimal> _capacities = new List<decimal>();

        //    foreach (var c in capacities)
        //    {
        //        if (c.ToString().Contains(capacityLetters.ToString()))
        //        {
        //            _capacities.Add(c);
        //        }

        //    }
        //    return (IQueryable<decimal>)_capacities;

        //}
        
        public IQueryable<Brand> UniqueBrands
        {
            get { return context.Brands; }
        }


        public IQueryable<AutoModel> UniqueAutoModels
        {
            get 
            {
                return (from m in context.AutoModels select m).Distinct();
            }
        }

        public IQueryable<AutoModel> GetAutoModelsByIdBrand(int? idBrand)
        {
            if (idBrand == null)
                return null;
            else
                return (from m in context.AutoModels
                        where m.IdBrand == idBrand
                        select m).Distinct();
        }

       
    }
}
