using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWorld.ViewModels;
using TheWorld.Services;
using Microsoft.Extensions.Configuration;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        //use dependency injection to get the mail service interface
        private IMailService _mailService;
        private IConfigurationRoot _config;

        public AppController(IMailService mailService, IConfigurationRoot config) {
            _mailService = mailService;
            _config = config;
        }
        public IActionResult Index() {


            return View();
        }

        public IActionResult Contact()//using "get" action by default
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model) //model gets filled up by using "Model Binding"
        {
            if (model.Email.Contains("aol.com")) {
                ModelState.AddModelError("Email", "We don't support AOL addresses");
            }
            if (ModelState.IsValid)
            {
                //using dependency injection again
                _mailService.SendMail(_config["MailSettings:ToAddress"], model.Email, "From The World", model.Message);

                ViewBag.UserMessage = "Message Sent";
            }
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
