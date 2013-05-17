using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Concrete;

namespace AutoTrade.Domain.Abstract
{
    public interface IVehiclesRepository
    {
        IQueryable<Vehicle> Vehicles { get; }

        IQueryable<VehiclesDetails> VehiclesDetail { get; }
        IQueryable<VehiclesDetails> GetVehiclesByAutoModelId (int id);

        IQueryable<VehiclesDetails> GetVehiclesByParams(int? idBrand, int? idAutoModel);

        VehiclesDetails GetVehicleDetailById(int id);

        Vehicle GetVehicleById(int id);

        void SaveVehicle(VehiclesDetails vehicle);

        void DeleteVehicle(Vehicle vehicle);

        IQueryable<AutoModel> UniqueAutoModels { get; }

        IQueryable<AutoModel> GetAutoModelsByBrandId(int? idBrand);

        IQueryable<Brand> UniqueBrands { get; }
        IQueryable<string> UniqueBrandsName { get; }
    }
}
