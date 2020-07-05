﻿using SistemaMediMan.Models;
using SistemaMediMan.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaMediMan.Controllers
{
    public class DeporteController : Controller
    {
        // GET: Deporte
        public ActionResult Index()
        {
            try
            {
                using (mediManContext db = new mediManContext())
                {
                    return View(db.DEPORTES.ToList());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET: Deporte/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Deporte/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Deporte/Create
        [HttpPost]
        public ActionResult Create(DEPORTES model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (mediManContext db = new mediManContext())
                    {
                        var dep = new DEPORTES();
                        dep.DEPORTE = model.DEPORTE;


                        db.DEPORTES.Add(dep);
                        db.SaveChanges();
                    }
                    return Redirect("Index/");
                }
                return View(model);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Error al crear registro " + e.Message);
                return View();
            }
        }

        // GET: Deporte/Edit/5
        public ActionResult Edit(int id)
        {
            using (mediManContext db = new mediManContext())
            {
                DEPORTES dep = db.DEPORTES.Find(id);
                return View(dep);
            }
        }

        // POST: Deporte/Edit/5
        [HttpPost]
        public ActionResult Edit(DEPORTES model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (mediManContext db = new mediManContext())
                    {
                        var dep = new DEPORTES();
                        dep.DEPORTE = model.DEPORTE;


                        db.DEPORTES.Add(dep);
                        db.SaveChanges();
                    }
                    return Redirect("Index/");
                }
                return View(model);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Error al actualizar " + e.Message);
                return View();
            }
        }

        // GET: Deporte/Delete/5
        public ActionResult Delete(int id)
        {
            using (mediManContext db = new mediManContext())
            {
                DEPORTES dep = db.DEPORTES.Find(id);
                db.DEPORTES.Remove(dep);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        // POST: Deporte/Delete/5
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
