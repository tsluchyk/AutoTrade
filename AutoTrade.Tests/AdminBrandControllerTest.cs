using AutoTrade.WebUI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using AutoTrade.Domain.Abstract;
using System.Web.Mvc;
using Moq;
using AutoTrade.Domain.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace AutoTrade.Tests
{
    
    
    /// <summary>
    ///Это класс теста для AdminBrandControllerTest, в котором должны
    ///находиться все модульные тесты AdminBrandControllerTest
    ///</summary>
    [TestClass()]
    public class AdminBrandControllerTest
    {

        [TestMethod]
        public void CanEditBrand()
        {
            Mock<IBrandsRepository> mock = new Mock<IBrandsRepository>();

            mock.Setup(m => m.Brands).Returns(new Brand[]{
                new Brand{Id=1, Name="1"},
                new Brand{Id=2, Name="2"},
                new Brand{Id=3, Name="3"}
            }.AsQueryable());

            AdminBrandController target = new AdminBrandController(mock.Object);

            Brand b1 = target.Edit(1).ViewData.Model as Brand;
            Brand b2 = target.Edit(2).ViewData.Model as Brand;
            Brand b3 = target.Edit(3).ViewData.Model as Brand;

            //Assert.AreEqual(1, b1.Id);
            //Assert.AreEqual(2, b2.Id);
            //Assert.AreEqual(3, b3.Id);
        }
    }
}
