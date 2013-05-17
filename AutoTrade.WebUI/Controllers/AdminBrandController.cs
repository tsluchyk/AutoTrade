using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoTrade.Domain.Abstract;
using AutoTrade.Domain.Concrete;

namespace AutoTrade.WebUI.Controllers
{
    public class AdminBrandController : Controller
    {
        private IBrandsRepository repository;

        public AdminBrandController(IBrandsRepository repo)
        {
            repository = repo;
        }

        public ActionResult BrandsDigest(int? ActualBrands)
        {
            List<Brand> brands = new List<Brand>();

            if (ActualBrands == null)
                foreach (var b in repository.Brands)
                    brands.Add(b);
            else
            {
                brands.Add(repository.GetBrandById((int)ActualBrands));
            }

            if(Request.IsAjaxRequest())
            {
               return PartialView("Ajax_BrandTable", brands);
            }

            return View(brands);
        }

        public ViewResult Edit(int id)
        {
            Brand brand = repository.GetBrandById(id);
            ViewBag.Admin = 1;
            return View(brand);
        }

        [HttpPost]
        public ActionResult Edit(Brand brand)
        {
            if (ModelState.IsValid)
            {
                repository.SaveBrand(brand);
                TempData["message"] = string.Format("{0} has been saved", brand.Name);
                return RedirectToAction("BrandsDigest");
            }
            else
            {
                return View(brand);
            }
        }

        public ViewResult Create()
        {
            ViewBag.Admin = 0;
            return View("Edit", new Brand());
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Brand brand = repository.GetBrandById(id);

            if (brand != null)
            {
                repository.DeleteBrand(brand);
                TempData["message"] = string.Format("{0} was successful deleted", brand.Name);
            }

            return RedirectToAction("BrandsDigest");
        }
    }
}
