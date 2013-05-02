using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoTrade.Domain.Concrete
{
    public class VehiclesSummary
    {
       public int Id { get; set; }
       public string Brand { get; set; }
       public string AutoModel { get; set; }
       public string Color { get; set; }
       public decimal CubicCapacity { get; set; }
       public decimal Price { get; set; }
       public string Description { get; set; }
    }
}
