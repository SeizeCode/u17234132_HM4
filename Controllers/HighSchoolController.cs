using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models.HighSDatabse;

namespace WebApplication2.Controllers
{
    public class HighSchoolController : Controller
    {
        private readonly HighRep rep = new HighRep();
        // GET: HighSchool
        public ActionResult Index()
        {
            IEnumerable<HighSModel> obj = rep.SelectAllHigh();
            return View(obj);
        }
        public ActionResult Names(string searchname)
        {

            IEnumerable<HighSModel> obj = rep.SelectAllHigh();
            return View(obj.Where(x => x.mName.Contains(searchname) || searchname == null).ToList());

        }
     

        // GET: HighSchool/Details/5
        public ActionResult Details(int id)
        {
            HighSModel high = rep.SelecrById(id);
            return View(high);
        }

        // GET: HighSchool/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HighSchool/Create
        [HttpPost]
        public ActionResult Create(HighSModel high)
        {
            try
            {
                // 
                rep.CreateHigh(high);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HighSchool/Edit/5
        public ActionResult Edit(int id)
        {
            HighSModel high = rep.SelecrById(id);
            return View(high);
        }

        // POST: HighSchool/Edit/5
        [HttpPost]
        public ActionResult Edit(HighSModel high)
        {
            try
            {
                // 
                rep.UpdateHigh(high);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HighSchool/Delete/5
        public ActionResult Delete(int id)
        {
            HighSModel high = rep.SelecrById(id);
            return View(high);
        }

        // POST: HighSchool/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, HighSModel high)
        {
            try
            {
                // 
                rep.DeleteHigh(id,high);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
    }
}
