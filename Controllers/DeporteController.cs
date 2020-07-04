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
            List<ListDeporteViewModel> lista;
            using (mediManContext db = new mediManContext())
            {
                lista = (from d in db.DEPORTES
                         select new ListDeporteViewModel
                         {
                             Id=d.ID,
                             Nombre=d.DEPORTE,

                         }).ToList();
            }

            return View(lista);
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
        public ActionResult Create(ListDeporteViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (mediManContext db = new mediManContext())
                    {
                        var dep = new DEPORTES();
                        dep.DEPORTE = model.Nombre;


                        db.DEPORTES.Add(dep);
                        db.SaveChanges();
                    }
                    return Redirect("Index/");
                }
                return View(model);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // GET: Deporte/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Deporte/Edit/5
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

        // GET: Deporte/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
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
