using System;
using System.Linq;
using System.Web.Mvc;
using AutoTrade.Domain.Abstract;
using AutoTrade.WebUI.Models;
using AutoTrade.Domain;
using System.Web.Services;
using System.Collections.Generic;

namespace AutoTrade.WebUI.Controllers
{
    public class AutoModelController : Controller
    {
        private IVehiclesSummaryRepository vehiclesSummaryRepository;

        public AutoModelController(IVehiclesSummaryRepository repo)
        {
            vehiclesSummaryRepository = repo;
        }

        public ActionResult Grid(string color=null,
                                decimal? capacity = null,
                                decimal? minPrice = null,
                                decimal? maxPrice = null,
                                int itemsPerPage=30,
                                int page = 1,
                                string sort = "Brand",
                                string sortDir = "Ascending",
                                int? ActualAutoModels=null,
                                int? ActualBrands=null)
        {
            ViewBag.ActualBrands = new SelectList(vehiclesSummaryRepository.UniqueBrands, "Id", "Name");
            ViewBag.ActualAutoModels = new SelectList(vehiclesSummaryRepository.UniqueAutoModels, "Id", "Name");

            int totalItems;
            
            VehiclesSummaryModelForPaging vehiclesModel = new VehiclesSummaryModelForPaging
            {
                VehiclesSummary = vehiclesSummaryRepository.GetExtensionSequenceVehicles
                (
                out totalItems,
                itemPerPage: itemsPerPage,
                pageIndex: page -1,
                sort: sort,
                sortOrder: GetSortDirection(sortDir),
                color: color,
                capacity: capacity,
                minPrice: minPrice,
                maxPrice:maxPrice,
                idAutoModel:ActualAutoModels,
                idBrand: ActualBrands
                ),
                _PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = itemsPerPage,
                    TotalItems = vehiclesSummaryRepository.VehiclesSummary.Count()
                }
            };


            if (Request.IsAjaxRequest())
            {
                return PartialView("Ajax_Grid", vehiclesModel); ;
            }
            return View(vehiclesModel);

        }

        private _SortDirection GetSortDirection(string sortDirection)
        {
            if (sortDirection != null)
            {
                if (sortDirection.Equals("DESC", StringComparison.OrdinalIgnoreCase) ||
                    sortDirection.Equals("DESCENDING", StringComparison.OrdinalIgnoreCase))
                {
                    return _SortDirection.Descending;
                }
            }
            return _SortDirection.Ascending;
        }


        [WebMethod]
        public JsonResult GetUniqueColors(string term)
        {
            var colors = vehiclesSummaryRepository.GetUniqueColors(term, 10);
            return Json(colors, JsonRequestBehavior.AllowGet);
        }


        [WebMethod]
        public JsonResult GetUniqueCapacity(string term)
        {
            var capacities = vehiclesSummaryRepository.GetUniqueCapacity(term, 10);
            
            return Json(capacities, JsonRequestBehavior.AllowGet);
        }

       
    }
}
 