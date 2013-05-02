using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoTrade.Domain.Concrete;

namespace AutoTrade.WebUI.Models
{
    public class VehiclesSummaryModelForPaging
    {
        public IEnumerable<VehiclesSummary> VehiclesSummary { get; set; }
        public PagingInfo _PagingInfo { get; set; }
    }
}