using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Abstract;
using System.Data;

namespace AutoTrade.Domain.Concrete
{
    public class VehicleRepository : IVehiclesRepository
    {
        private AutoTradeEntities context = new AutoTradeEntities();

        public IQueryable<Vehicle> Vehicles
        {
            get
            {
                return context.Vehicles;
            }
        }

        public IQueryable<VehiclesDetails> VehiclesDetail
        {
            get
            {
                var vehicles = from v in context.Vehicles
                               select new VehiclesDetails
                               {
                                   Id = v.Id,
                                   Brand = v.AutoModel.Brand.Name,
                                   AutoModel = v.AutoModel.Name,
                                   Color = v.Color,
                                   CubicCapacity = v.CubicCapacity,
                                   Description = v.Description,
                                   Price = v.Price,
                                   History = v.PricesHistories
                               };
                return vehicles;
            }
        }

        public IQueryable<VehiclesDetails> GetVehiclesByAutoModelId(int id)
        {
            var vehicles = from v in context.Vehicles
                           where v.IdAutoModel == id
                           select new VehiclesDetails
                           {
                               Id = v.Id,
                               Brand = v.AutoModel.Brand.Name,
                               AutoModel = v.AutoModel.Name,
                               Color = v.Color,
                               CubicCapacity = v.CubicCapacity,
                               Description = v.Description,
                               Price = v.Price,
                               History = v.PricesHistories
                           };
            return vehicles;
        }

        public IQueryable<VehiclesDetails> GetVehiclesByParams(int? idBrand, int? idAutoModel)
        {
            var vehicles = new VehicleSearchSpecification()
            {
                IdAutoModel = idAutoModel,
                IdBrand = idBrand
            }.SatisfiedBy(context.Vehicles);

            var vehiclesSequence = from v in vehicles
                           select new VehiclesDetails
                           {
                               Id = v.Id,
                               Brand = v.AutoModel.Brand.Name,
                               AutoModel = v.AutoModel.Name,
                               Color = v.Color,
                               CubicCapacity = v.CubicCapacity,
                               Description = v.Description,
                               Price = v.Price,
                               History = v.PricesHistories
                           };
            return vehiclesSequence;
        }

        public IQueryable<AutoModel> GetAutoModelsByBrandId(int? idBrand)
        {
            if (idBrand == null)
                return null;
            else
                return (from a in context.AutoModels
                              where a.IdBrand == idBrand
                              select a)
                              .Distinct();
        }

        public VehiclesDetails GetVehicleDetailById(int id)
        {
            var v = context.Vehicles.Where(x => x.Id == id).FirstOrDefault();

            return new VehiclesDetails
            {
                Id = v.Id,
                Brand = v.AutoModel.Brand.Name,
                AutoModel = v.AutoModel.Name,
                Color = v.Color,
                CubicCapacity = v.CubicCapacity,
                Description = v.Description,
                Price = v.Price,
                History = v.PricesHistories

            };
        }

        public Vehicle GetVehicleById(int id)
        {
            return context.Vehicles.Where(x => x.Id == id).FirstOrDefault();
        }

        private void SaveNewVehicle(VehiclesDetails vehicle)
        {
            context.Vehicles.Add(new Vehicle
            {
                // find auto model not only for Name? but Id
                IdAutoModel = context.AutoModels.Where(x =>
                    x.Name.Equals(vehicle.AutoModel) && x.Brand.Name.Equals(vehicle.Brand)
                    ).FirstOrDefault().Id,
                Color = vehicle.Color,
                CubicCapacity = vehicle.CubicCapacity,
                Price = vehicle.Price,
                Description = vehicle.Description
            });
            context.SaveChanges();
        }

        private void SaveNewAutoModel(VehiclesDetails vehicle)
        {
            context.AutoModels.Add(new AutoModel
            {
                IdBrand = context.Brands.Where(x => x.Name.Equals(vehicle.Brand)).FirstOrDefault().Id,
                Name = vehicle.AutoModel
            });

            context.SaveChanges();
        }

        private void SaveEditVehicle(VehiclesDetails vehicle)
        {
            Vehicle v = context.Vehicles.Where(x => x.Id == vehicle.Id).FirstOrDefault();
           // v.AutoModel.Brand = context.Brands.Where(x => x.Name.Equals(vehicle.Brand)).FirstOrDefault();
            v.IdAutoModel = context.AutoModels.Where(x => 
                x.Name.Equals(vehicle.AutoModel) && x.Brand.Name.Equals(vehicle.Brand)
                ).FirstOrDefault().Id;
            v.Color = vehicle.Color;
            v.CubicCapacity = vehicle.CubicCapacity;
            v.Price = vehicle.Price;
            v.Description = vehicle.Description;

            context.Entry(v).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void SaveVehicle(VehiclesDetails vehicle)
        {
            //new model (name unique)
            if (context.AutoModels.Where(x => x.Name.Equals(vehicle.AutoModel)).FirstOrDefault() == null)
                SaveNewAutoModel(vehicle);

            //new model (name not unique , para brand-name unique)
            if (context.AutoModels.Where(x =>
                x.Name.Equals(vehicle.AutoModel)
                &&
                x.Brand.Name.Equals(vehicle.Brand)
            ).FirstOrDefault() == null)
                SaveNewAutoModel(vehicle);

            if (vehicle.Id == 0)
                SaveNewVehicle(vehicle);
            else
                SaveEditVehicle(vehicle);
        }

        public void DeleteVehicle(Vehicle vehicle)
        {
            var id = vehicle.AutoModel.Id;
            context.Vehicles.Remove(vehicle);

            var autoModel = context.AutoModels.Where(x => x.Id == id).FirstOrDefault();
            if (autoModel.Vehicles.Count == 0)
            {
                var idBrand = autoModel.IdBrand;
                context.AutoModels.Remove(autoModel);

                var brand = context.Brands.Where(x => x.Id == idBrand).FirstOrDefault();
                if (brand.AutoModels.Count == 0)
                    context.Brands.Remove(brand);
            }


            if (context.PricesHistories != null)
            {
                var itemHistory = from h in context.PricesHistories
                                  where h.IdVehicle == vehicle.Id
                                  select h;

                if (itemHistory != null)
                    foreach (var v in itemHistory)
                    {
                        context.PricesHistories.Remove(v);
                    }
            }

            context.SaveChanges();
        }


        public IQueryable<AutoModel> UniqueAutoModels
        {
            get
            {
                var models = (from m in context.Vehicles
                              select m.AutoModel)
                             .Distinct();
                return models;
            }
        }


        public IQueryable<Brand> UniqueBrands
        {
            get
            {
                var brands = (from b in context.Brands
                              select b)
                              .Distinct();
                return brands;
            }
        }

        public IQueryable<string> UniqueBrandsName
        {
            get
            {
                var brands = (from b in context.Brands
                              select b.Name)
                              .Distinct();
                return brands;
            }
        }


        
    }
}
