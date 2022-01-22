using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bakery.Controllers
{
    public class CakeCreatorViewController : Controller
    {
        // GET: CakeCreatorView
        public ActionResult Index()
        {
            return View();
        }

        // GET: CakeCreatorView/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CakeCreatorView/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CakeCreatorView/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CakeCreatorView/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CakeCreatorView/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CakeCreatorView/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CakeCreatorView/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
