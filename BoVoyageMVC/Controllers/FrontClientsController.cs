﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoVoyageMVC.Controllers
{
    [RouteArea("")]
    public class FrontClientsController : BaseController
    {
        // GET: FrontClients
        public ActionResult Index()
        {
            return View();
        }

        // GET: FrontClients/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FrontClients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FrontClients/Create
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

        // GET: FrontClients/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FrontClients/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {           
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FrontClients/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FrontClients/Delete/5
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
