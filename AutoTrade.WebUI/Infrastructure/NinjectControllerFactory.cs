using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using System.Web.Routing;
using AutoTrade.Domain.Abstract;
using AutoTrade.Domain.Concrete;

namespace AutoTrade.WebUI.Infrastructure
{
    public class NinjectControllerFactory: DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext context, Type type)
        {
            return type == null ? null : (IController)ninjectKernel.Get(type);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IAutoModelsRepository>().To<AutoModelsRepository>();
            ninjectKernel.Bind<IBrandsRepository>().To<BrandsRepository>();
            ninjectKernel.Bind<IVehiclesRepository>().To<VehicleRepository>();

            ninjectKernel.Bind<IVehiclesSummaryRepository>().To<VehiclesSummaryRepository>();
        }

    }
}