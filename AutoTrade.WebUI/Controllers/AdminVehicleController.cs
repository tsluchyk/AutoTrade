using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoTrade.Domain.Abstract;
using AutoTrade.Domain.Concrete;
using System.Web.Services;

namespace AutoTrade.WebUI.Controllers
{
    public class AdminVehicleController : Controller
    {
        private IVehiclesRepository repository;

        public AdminVehicleController(IVehiclesRepository repo)
        {
            repository = repo;
        }

        //public ActionResult VehiclesDigest(int? ActualAutoModels)
        //{
        //    IQueryable<VehiclesDetails> vehicles;

        //    if (ActualAutoModels == null)
        //        vehicles = repository.VehiclesDetail;
        //    else
        //        vehicles = repository.GetVehiclesByAutoModelId((int)ActualAutoModels);

        //    ViewBag.ActualAutoModels = new SelectList(repository.UniqueAutoModels, "Id", "Name");

        //    if (Request.IsAjaxRequest())
        //    {
        //        return PartialView("Ajax_VehicleTable", vehicles);
        //    }
        //    return View(vehicles);
        //}

        public ActionResult VehiclesDigest(int? ActualBrands=null, int? ActualAutoModels=null)
        {
            ViewBag.ActualBrands = new SelectList(repository.UniqueBrands , "Id", "Name");
            ViewBag.ActualAutoModels = new SelectList(new List<string>());

            IQueryable<VehiclesDetails> vehicles = repository.GetVehiclesByParams(ActualBrands, ActualAutoModels);

            if (Request.IsAjaxRequest())
            {
                return PartialView("Ajax_VehicleTable", vehicles);
            }
            return View(vehicles);
        }

        [WebMethod]
        public JsonResult GetAutoModelsByBrandId(int? id)
        {
            var autoModels = repository.GetAutoModelsByBrandId(id);
              
            if (autoModels != null)
                ViewBag.ActualAutoModels = new SelectList(autoModels, "Id", "Name");

            return Json(ViewBag.ActualAutoModels, JsonRequestBehavior.AllowGet);
        }


  
        public ViewResult Edit(int id)
        {
            VehiclesDetails vehicle = repository.GetVehicleDetailById(id);
            ViewBag.ActualBrandsName = repository.UniqueBrandsName;
            ViewBag.Admin =  1;
            return View(vehicle);
        }

        [HttpPost]
        public ActionResult Edit(VehiclesDetails vehicle)
        {
            if (ModelState.IsValid)
            {
                repository.SaveVehicle(vehicle);
                TempData["message"] = string.Format("{0} has been saved", vehicle.AutoModel);
                return RedirectToAction("VehiclesDigest");
            }
            else
            {
                return View(vehicle);
            }
        }

        public ViewResult Create()
        {
            ViewBag.ActualBrandsName = repository.UniqueBrandsName;
            ViewBag.Admin = 0;
            return View("Edit", new VehiclesDetails());
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Vehicle vehicle = repository.GetVehicleById(id);
            if (vehicle != null)
            {
                repository.DeleteVehicle(vehicle);
                TempData["message"] = string.Format("{0} was successful deleted", vehicle.AutoModel);
            }

            return RedirectToAction("VehiclesDigest");
        }
    }
}
