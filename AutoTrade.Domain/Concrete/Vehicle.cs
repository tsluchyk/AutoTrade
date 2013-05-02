//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace AutoTrade.Domain.Concrete
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            this.PricesHistories = new HashSet<PricesHistory>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdAutoModel { get; set; }
        public string Color { get; set; }
        public decimal CubicCapacity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    
        public virtual AutoModel AutoModel { get; set; }
        public virtual ICollection<PricesHistory> PricesHistories { get; set; }
    }
    
}
