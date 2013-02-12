using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestSharp;
using hydra.Models;

namespace hydra.Controllers
{
    public class OpmlController : Controller
    {
        //
        // GET: /Opml/

        public ActionResult Index()
        {
            //Should return a list of all categories in opml format
            var srApi = new SrApi();
            var programCategories = srApi.GetProgramCategories();

            return View(programCategories);
        }

    }
}
