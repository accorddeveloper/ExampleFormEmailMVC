using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExampleFormEmailMVC.Models;

namespace ExampleFormEmailMVC.Controllers
{
    [RoutePrefix("/")]
    public class IndexController : Controller
    {
        [HttpGet]
        [Route("Index")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("GenericForm")]
        public ActionResult GenericForm()
        {
            return View();
        }

        [HttpPost]
        [Route("GenericForm")]
        public ActionResult GenericForm(GenericFormModel model)
        {
            return View();
        }

    }
}