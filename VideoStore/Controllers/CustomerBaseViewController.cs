﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using VideoStore.Models;

namespace VideoStore.Controllers
{
    public class CustomerBaseViewController : Controller
    {
        
        // GET: CustomerBaseView
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerBaseView/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerBaseView/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerBaseView/Create
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

        // GET: CustomerBaseView/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerBaseView/Edit/5
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

        // GET: CustomerBaseView/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerBaseView/Delete/5
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
