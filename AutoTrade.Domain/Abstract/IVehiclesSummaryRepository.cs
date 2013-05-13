using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Concrete;

namespace AutoTrade.Domain.Abstract
{
    public interface IVehiclesSummaryRepository
    {
        IQueryable<VehiclesSummary> VehiclesSummary { get; }

        IQueryable<VehiclesSummary> GetSequenceVehicles(out int totalItems,
            int itemPerPage = -1,
            int pageIndex = -1,
            string sort = "Brand",
            _SortDirection sortOrder = _SortDirection.Ascending);


        IQueryable<VehiclesSummary> GetExtensionSequenceVehicles(out int totalItems,
            int itemPerPage = -1,
            int pageIndex = -1,
            string sort = "Brand",
            _SortDirection sortOrder = _SortDirection.Ascending,
            string color = null,
            decimal? capacity = null,
            decimal? minPrice = null,
            decimal? maxPrice = null,
            int? idAutoModel=null,
            int? idBrand=null);

        IQueryable<string> GetUniqueColors(string colorLetters, int maxCount);

        IQueryable<string> GetUniqueCapacity(string capacityLetters, int maxCount);
       // IQueryable<decimal> GetUniqueCapacity(decimal capacityLetters, int maxCount);

        IQueryable<Brand> UniqueBrands { get; }
        
        IQueryable<AutoModel> UniqueAutoModels { get; }

        IQueryable<AutoModel> GetAutoModelsByIdBrand(int? idBrand);
    }
}


