using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SecondaryController : Controller
    {
        private readonly Models.SecondaryDatabase.SecondaryRep rep = new Models.SecondaryDatabase.SecondaryRep();

        // GET: Secondary
        public ActionResult Index()
        {
            IEnumerable<Models.SecondaryDatabase.SecondaryModel> obj = rep.SelectAllSecondary();
            return View( obj);
        }

        // GET: Secondary/Details/5
        public ActionResult Details(int id)
        {
            Models.SecondaryDatabase.SecondaryModel sec = rep.SelectById(id);
            return View(sec);
        }
        public ActionResult Names(string searchname)
        {

            IEnumerable<Models.SecondaryDatabase.SecondaryModel> obj = rep.SelectAllSecondary();
            return View(obj.Where(x => x.mName.Contains(searchname) || searchname == null).ToList());

        }
        // GET: Secondary/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Secondary/Create
        [HttpPost]
        public ActionResult Create(Models.SecondaryDatabase.SecondaryModel sec)
        {
            try
            {
                //
                rep.CreateSecondary(sec);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Secondary/Edit/5
        public ActionResult Edit(int id)
        {
            Models.SecondaryDatabase.SecondaryModel sec = rep.SelectById(id);
            return View(sec);
        }

        // POST: Secondary/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.SecondaryDatabase.SecondaryModel sec)
        {
            try
            {
                //
                rep.UpdateSecondary(sec);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Secondary/Delete/5
        public ActionResult Delete(int id)
        {
            Models.SecondaryDatabase.SecondaryModel sec = rep.SelectById(id);
            return View(sec);
        }

        // POST: Secondary/Delete/5
        [HttpPost]
        public ActionResult Delete(int id,Models.SecondaryDatabase.SecondaryModel sec)
        {
            try
            {
                // 
                rep.DeleteSecondary(id, sec);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
