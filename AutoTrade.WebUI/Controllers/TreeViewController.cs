using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoTrade.Domain.Abstract;
using Lib.Web.Mvc.JQuery.TreeView;
using AutoTrade.Domain.Concrete;
using AutoTrade.WebUI.Models;

namespace AutoTrade.WebUI.Controllers
{
    public class TreeViewController : Controller
    {
        private IBrandsRepository brandsRepository;

        public TreeViewController(IBrandsRepository repo)
        {
            brandsRepository = repo;
        }

        public ActionResult RenderTree()
        {
            return PartialView();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult RenderTree(string root)
        {
            int? nodeId = (root == "source") ? (int?)null : Convert.ToInt32(root);

            List<TreeViewNode> nodes = new List<TreeViewNode>();

            if (nodeId == null)
            {
                IEnumerable<Brand> children = brandsRepository.Brands;
                foreach (var c in children)
                {
                    nodes.Add(new TreeViewNode()
                    {
                        id = Convert.ToString(c.Id),
                        text = c.Name,
                        classes = "folder",
                        hasChildren = true
                    });
                }
            }
            else
            {
                IEnumerable<AutoModel> children = brandsRepository.Brands.Where(i => i.Id == nodeId).First().AutoModels;
                foreach (var c in children)
                {
                    nodes.Add(new TreeViewNode()
                    {
                        id = Convert.ToString(c.Id),
                        text = c.Name,
                        classes = "file",
                        hasChildren = false
                    });
                }
            }
            return Json(nodes);
        }


    }
}
