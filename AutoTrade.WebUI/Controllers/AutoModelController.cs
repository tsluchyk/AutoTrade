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
        //private IBrandsRepository brandsRepository;
        //private IAutoModelsRepository autoModelRepository;
        //private IVehiclesRepository vehiclesRepository;

        private IVehiclesSummaryRepository vehiclesSummaryRepository;
       // static int _pageSize = 30;

        //public int PageSize
        //{
        //    get { return _pageSize; }
        //    set { _pageSize = value; }
        //}
        //public List<string> DropDownItems { private set; get; }

        public AutoModelController(IVehiclesSummaryRepository repo)
        {
            vehiclesSummaryRepository = repo;
           // DropDownItems = new List<string> { "10", "50", "100", "all" };
        }
        /*int? page, int? rowsPerPage, 
              string sort, string sortdir, 
              string orderNumber, string person, string product*/
        

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
                //VehiclesSummary=vehiclesSummaryRepository.GetSequenceVehicles
                VehiclesSummary = vehiclesSummaryRepository.GetExtensionSequenceVehicles
                (
                out totalItems,
                //itemPerPage: PageSize,
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
                   // ItemsPerPage = PageSize,
                    ItemsPerPage = itemsPerPage,
                    TotalItems = vehiclesSummaryRepository.VehiclesSummary.Count()
                }
            };

            //ViewBag.TotalItems = vehiclesModel.VehiclesSummary.Count();

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

        //[WebMethod]
        //public void ChangeItemsPerPage(string count)
        //{
        //    PageSize = Convert.ToInt32(count);
        //}

        [WebMethod]
        public JsonResult GetUniqueColors(string term)
        {
            var colors = vehiclesSummaryRepository.GetUniqueColors(term, 10);
            return Json(colors, JsonRequestBehavior.AllowGet);
        }

        //[WebMethod]
        //public JsonResult GetUniqueCapacity(string term)
        //{
        //    var capacities = vehiclesSummaryRepository.GetUniqueCapacity(term, 10);
        //    return Json(capacities, JsonRequestBehavior.AllowGet);
        //}

        [WebMethod]
        public JsonResult GetUniqueCapacity(string term)
        {
            var capacities = vehiclesSummaryRepository.GetUniqueCapacity(term, 10);
            
            return Json(capacities, JsonRequestBehavior.AllowGet);
        }

       
    }
}
 