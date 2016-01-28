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
        private Webservice _webservice = new Webservice();
        public ActionResult Index()
        {
            var kpi_groups = _webservice.GetKpiGroups();

            return View(kpi_groups);
        }

        public ActionResult Kpi()
        {
            var kpi = _webservice.GetKpi();
            return View(kpi);
        }

        public ActionResult MunicipalityGroups()
        {
            var mg = _webservice.GetMunicipalityGroups();

            return View(mg);
        }

        public ActionResult Municipality()
        {
            var m = _webservice.GetMunicipality();

            return View(m);
        }

        public ActionResult Ou()
        {
            var ou = _webservice.GetOu();

            return View(ou);
        }


    }
}