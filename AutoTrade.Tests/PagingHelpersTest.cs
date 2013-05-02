using AutoTrade.WebUI.HtmlHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;
using AutoTrade.WebUI.Models;

namespace AutoTrade.Tests
{
  
    [TestClass()]
    public class PagingHelpersTest
    {
        [TestMethod]
        public void PageLinksTest()
        {
            HtmlHelper hlp = null;

            PagingInfo pagingInfo = new PagingInfo
            {
                CurrentPage=2,
                ItemsPerPage=3,
                TotalItems=9
            };

            Func<int, string> pageUrlDelegate = i => "Page" + i;

            MvcHtmlString result = hlp.PageLinks(pagingInfo, pageUrlDelegate);

            Assert.AreEqual(result.ToString(), @"<a href=""Page1"">1</a><a class=""selected"" href=""Page2"">2</a><a href=""Page3"">3</a>");
        }

    }
}
