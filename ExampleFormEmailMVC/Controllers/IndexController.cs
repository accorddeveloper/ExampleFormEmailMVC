using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using ExampleFormEmailMVC.Models;
using ExampleFormEmailMVC.Ultility;

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
            if (ModelState.IsValid)
            {
                var json = new JavaScriptSerializer().Serialize(model);
                //You will need to provide your email address and password to the smtp configuration in the root Web.config 
                //Email.Send(json);
            }
            return View(model);
        }

    }
}