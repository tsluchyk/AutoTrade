using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Concrete;

namespace AutoTrade.Domain.Abstract
{
    public interface IBrandsRepository
    {
        IQueryable<Brand> Brands { get; }

        Brand GetBrandById(int id);

        void SaveBrand(Brand brand);

        void DeleteBrand(Brand brand);
    }
}
