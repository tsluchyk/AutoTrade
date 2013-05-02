﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTrade.WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        
    }
}