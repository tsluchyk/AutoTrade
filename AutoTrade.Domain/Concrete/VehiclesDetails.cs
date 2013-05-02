using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AutoTrade.Domain.Concrete
{
    public class VehiclesDetails
    {
        [ScaffoldColumn(false)]
        //[HiddenInput(DisplayValue=false)]
        public int Id { get; set; }

        [Required(ErrorMessage="Please, enter a brand name")]
        [UIHint("BrandsDropDownList")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Please, enter a model name")]
        [Display(Name="Model")]
        public string AutoModel { get; set; }

        [Required(ErrorMessage = "Please, enter a color")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Please, enter a cubic capacity")]
        [Display(Name = "Cubic capacity")]
        public decimal CubicCapacity { get; set; }

        [Required(ErrorMessage = "Please, enter a price")]
        [Range(0.01, double.MaxValue, ErrorMessage="Please, enter a positive price")]
        public decimal Price { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public ICollection<PricesHistory> History { get; set; }

    }
}
