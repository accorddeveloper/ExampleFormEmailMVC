using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
            //Bad coding to put email component here, but putting it here for now
            SmtpClient client = new SmtpClient();//Adding smtp host later
            MailAddress from = new MailAddress("test");
            MailAddress to = new MailAddress("test");
            MailMessage message = new MailMessage(from, to);       
            //message.Body = [ model.ExampleAddress, model.ExampleDate, model.ExampleName, model.ExamplePhoneNumber];

            //To be completed at another time
            return View();
        }

    }
}