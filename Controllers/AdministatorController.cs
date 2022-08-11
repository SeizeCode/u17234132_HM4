using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class AdministatorController : Controller
    {
        // GET: Administator
        public ActionResult Index(string username,string password)
        {
            try
            {
                var usernam = "Nkosinathi";
                var pass = "Msiza";
                if(username==usernam || password == pass)
                {
                    RedirectToAction("Index", "Primary");
                }
                else
                {
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
            return View();
            
        }
        public ActionResult About()
        {
            return View();
        }
    }
}