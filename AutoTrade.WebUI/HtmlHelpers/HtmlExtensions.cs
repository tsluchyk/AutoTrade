﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace AutoTrade.WebUI.HtmlHelpers
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString Section(this HtmlHelper htmlHelper, Func<object, HelperResult> template, string addToSection)
        {
            htmlHelper.ViewContext.HttpContext.Items[String.Concat("_", addToSection, "_", Guid.NewGuid())] = template;
            return MvcHtmlString.Empty;
        }

        public static IHtmlString RenderSection(this HtmlHelper htmlHelper, string sectionName)
        {
            foreach (object key in htmlHelper.ViewContext.HttpContext.Items.Keys)
            {
                if (key.ToString().StartsWith(String.Concat("_", sectionName, "_")))
                {
                    var template = htmlHelper.ViewContext.HttpContext.Items[key] as Func<object, HelperResult>;
                    if (template != null)
                    {
                        htmlHelper.ViewContext.Writer.Write(template(null));
                    }
                }
            }
            return MvcHtmlString.Empty;
        }
    }
}