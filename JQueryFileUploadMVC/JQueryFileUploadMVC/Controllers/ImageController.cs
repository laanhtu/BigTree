namespace JQueryFileUploadMVC.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using JQueryFileUploadMVC.Models;

    public class ImageController : Controller
    {
        #region Methods

        //
        // GET: /Image/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Image/Create
        [HttpPost]
        public ActionResult Create(ImageViewModel model)
        {
            try
            {
                model.Id = new Random().Next(3000);

                return RedirectToAction("Edit", new { Id = model.Id });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Image/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Image/Delete/5
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

        //
        // GET: /Image/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Image/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Image/Edit/5
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

        //
        // GET: /Image/
        public ActionResult Index()
        {
            return View();
        }

        public void Upload(ImageViewModel model)
        {
            // Disme thang amagri
        }

        #endregion Methods
    }
}