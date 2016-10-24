using MvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View();
        }

        [HttpPost]
        public ActionResult SearchResult(SearchCriteria searchCriteria)
        {



            return View();
        }

        [HttpPost]
        public ActionResult SearchCriteriaInfo(FormCollection form)
        {

            string[] keys = Request.Form.AllKeys;
            for (int i = 0; i < keys.Length; i++)
            {
                Response.Write(keys[i] + ": " + Request.Form[keys[i]] + "<br>");
            }

            //form.AllKeys

            return View();
        }

    }
}
