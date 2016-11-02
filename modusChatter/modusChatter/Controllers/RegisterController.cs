using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using modusChatter.Models;

namespace modusChatter.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult register(Register reg)
        {
            if (ModelState.IsValid)
            {
                

            }
            return View();
        }

        //[Authorize]
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Index");

        }
     
    }
    
}