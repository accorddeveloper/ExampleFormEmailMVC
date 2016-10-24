using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Web.Services.Description;

namespace ExampleFormEmailMVC.Ultility
{
    public class Email
    {
        public static void Send(string content)
        {
            SmtpClient client = new SmtpClient();
            MailMessage email = new MailMessage("example@gmail.com", "example@gmail.com");

            email.Subject = "Generic Form";
            email.Body = content;
            email.IsBodyHtml = true;

            client.Send(email);
        }
        
    }
}