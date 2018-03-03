using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using DOTNETWEB_KCREVOLUTION.Areas.Engage.Models;
using DOTNETWEB_KCREVOLUTION.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DOTNETWEB_KCREVOLUTION.Areas.Engage.Controllers
{
    [Area("Engage")]
    public class EngageController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new EngageViewModel();
            return View(model);
        }

        public IActionResult Service()
        {
            var model = new ServiceViewModel();
            return View(model);
        }

        public IActionResult Contact()
        {
            var model = new ContactViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact([FromForm]EmailDTO emailForm)
        {
            if (ModelState.IsValid)
            {
                // need to send email here
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;

                System.Net.NetworkCredential creds = new System.Net.NetworkCredential("jajoh143@gmail.com", "Johnson143!");
                client.UseDefaultCredentials = false;
                client.Credentials = creds;

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("jajoh143@gmail.com");
                msg.To.Add(new MailAddress("kcrevolutionoffice@gmail.com"));

                msg.Subject = "Contact Form";
                msg.IsBodyHtml = true;
                msg.Body = string.Format(" Contact Name = {0} <br/> Email = {1} <br/>",
                    emailForm.Name, emailForm.Email, emailForm.Phone);
                if (emailForm.Phone != null)
                    msg.Body += string.Format(" Phone = {0} <br/> ", emailForm.Phone);
                msg.Body += emailForm.FormText;

                try
                {
                    client.Send(msg);
                    ViewBag.Message = "Your message has been successfully sent";
                }
                catch(Exception e)
                {
                    ViewBag.Message = "Error occured while sending your message. " + e.Message;
                    throw e;
                }
                var contactViewModel = new ContactViewModel();
                return View(contactViewModel);

            }
            else
            {
                return View(ModelState);
            }
        }

    }
}
