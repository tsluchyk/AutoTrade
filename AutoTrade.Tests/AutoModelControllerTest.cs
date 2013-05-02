using AutoTrade.WebUI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using AutoTrade.Domain.Abstract;
using System.Web.Mvc;
using Moq;
using AutoTrade.Domain.Concrete;
using System.Linq;
using System.Collections.Generic;
using AutoTrade.WebUI.Models;

namespace AutoTrade.Tests
{
    [TestClass()]
    public class AutoModelControllerTest
    {
  
        [TestMethod]
        public void CanPaging()
        {
            Mock<IAutoModelsRepository> mock = new Mock<IAutoModelsRepository>();
            mock.Setup(m => m.AutoModels).Returns(new AutoModel[]{
                new AutoModel{Id=1,Name="1"},
                new AutoModel{Id=1,Name="2"},
                new AutoModel{Id=1,Name="3"},
                new AutoModel{Id=1,Name="4"},
                new AutoModel{Id=1,Name="5"},
                new AutoModel{Id=1,Name="6"}
            }.AsQueryable());

            AutoModelController controller = new AutoModelController(mock.Object);
            controller.PageSize = 3;
            
            //IEnumerable<AutoModel> result = (IEnumerable<AutoModel>)controller.List(2).Model;
            AutoModelsListForPaging result = (AutoModelsListForPaging)controller.List(2).Model;

            //AutoModel[] models = result.ToArray();
            AutoModel[] models = result.AutoModels.ToArray();
            Assert.IsTrue(models.Length == 3);
            Assert.AreEqual(models[0].Name, "4");
            Assert.AreEqual(models[1].Name, "5");
            Assert.AreEqual(models[2].Name, "6");

        }

        [TestMethod]
        public void SendPagingViewModel()
        {
            Mock<IAutoModelsRepository> mock = new Mock<IAutoModelsRepository>();
            mock.Setup(m => m.AutoModels).Returns(new AutoModel[]{
                new AutoModel{Id=1,Name="1"},
                new AutoModel{Id=1,Name="2"},
                new AutoModel{Id=1,Name="3"},
                new AutoModel{Id=1,Name="4"},
                new AutoModel{Id=1,Name="5"},
                new AutoModel{Id=1,Name="6"}
            }.AsQueryable());

            AutoModelController controller = new AutoModelController(mock.Object);
            controller.PageSize = 2;

            AutoModelsListForPaging result = (AutoModelsListForPaging)controller.List(2).Model;

            PagingInfo pagingInfo = result._PagingInfo;
            
            Assert.AreEqual(pagingInfo.CurrentPage, 2);
            Assert.AreEqual(pagingInfo.ItemsPerPage, 2);
            Assert.AreEqual(pagingInfo.TotalItems, 6);
            Assert.AreEqual(pagingInfo.TotalPages, 3);

        }


    
    }
}
