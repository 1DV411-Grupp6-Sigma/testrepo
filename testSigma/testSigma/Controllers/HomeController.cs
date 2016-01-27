using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testSigma.Models;

namespace testSigma.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var webservice = new Webservice();
            //var municioalityId = webservice.GetMunicipalityId("kalmar");
            var kpi_groups = webservice.GetKpiGroups();

            return View(kpi_groups);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}