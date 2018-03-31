using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEncryptor.Classes;

namespace WebEncryptor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public string Index(string msg)
        {
            var message = new Message(msg);
            return message.getEncryptedMsg();
        }

    }
}