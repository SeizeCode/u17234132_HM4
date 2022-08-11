using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PrimaryController : Controller
    {

        private readonly PrimaryRep rep = new PrimaryRep();
        // GET: Primary
        public ActionResult Index()
        {
            IEnumerable<PrimaryModel> obj = rep.SelectAllPrimary();

            return View(obj);
        }
        public ActionResult Names(string searchname)
        {
          
            IEnumerable<PrimaryModel> obj = rep.SelectAllPrimary();
            return View(obj.Where(x => x.mName.Contains(searchname) || searchname==null).ToList());
           
        }
        
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
       public ActionResult Create(PrimaryModel prim)
        {
            try
            {
                rep.CreatePrimary(prim);
                return RedirectToAction("Index");
            }
            catch 
            {

                return View();
            }
        }
        //Get edit
        public ActionResult Edit(int id)
        {
            PrimaryModel prim = rep.SelectByid(id);
            return View(prim);
        }
        //EDIT pRIMARY
        [HttpPost]
        public ActionResult Edit(PrimaryModel prim)
        {
            try
            {
                rep.UpdatePrimary(prim);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }
        }
        //delete get
        public ActionResult Delete(int id)
        {
            PrimaryModel prim = rep.SelectByid(id);
            return View(prim);
        }
        [HttpPost]
        public ActionResult Delete(int id,PrimaryModel prim)
        {
            try
            {
                rep.DeletePrimary(id, prim);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }
        }
        public ActionResult Details(int id)
        {
            PrimaryModel prim = rep.SelectByid(id);
            return View(prim);
        }
    }
}