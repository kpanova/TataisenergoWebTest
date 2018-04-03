using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEncryptor.Classes;
using System.Data.Entity;
using WebEncryptor.Interfaces;
using WebEncryptor.Models.Classes;

namespace WebEncryptor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DBConnector.getConnection();
            DBConnector.getConnection().Tables();
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public string Index(string msg)
        {
            IEncryptor encrypt;
            encrypt = new Encryptor();
            DBConnector.getConnection().context.Messages.Add(new Message(msg));
            DBConnector.getConnection().context.SaveChanges();
            return encrypt.Encrypt(msg);
        }

    }
}