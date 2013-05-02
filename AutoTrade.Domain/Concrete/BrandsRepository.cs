using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoTrade.Domain.Abstract;
using System.Data;

namespace AutoTrade.Domain.Concrete
{
    public class BrandsRepository:IBrandsRepository
    {
        private AutoTradeEntities context = new AutoTradeEntities();

        public IQueryable<Brand> Brands
        {
            get
            {
                return context.Brands;
            }
        }


        public Brand GetBrandById(int id)
        {
            return context.Brands.Where(x => x.Id == id).FirstOrDefault();
        }


        public void SaveBrand(Brand brand)
        {
            if (brand.Id == 0)
                context.Brands.Add(brand);
            else
                context.Entry(brand).State = EntityState.Modified;
            //http://www.sitepoint.com/forums/showthread.php?808362-MVC-SaveChanges()-doesn-t-seem-to-work-with-passed-object

            context.SaveChanges();
        }


        public void DeleteBrand(Brand brand)
        {
            context.Brands.Remove(brand);
            context.SaveChanges();
        }
    }
}
