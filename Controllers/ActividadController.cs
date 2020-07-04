using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaMediMan.Models;
using SistemaMediMan.Models.ViewModels;

namespace SistemaMediMan.Controllers
{
    public class ActividadController : Controller
    {
        // GET: Actividad
        public ActionResult Index()
        {
            List<ListActividadViewModel> lista;
            using (mediManContext db = new mediManContext())
            {
                lista = (from d in db.ACTIVIDADES
                         select new ListActividadViewModel
                         {
                             Id=d.ID,
                             Nombre=d.ACTIVIDAD,

                         }).ToList();
            }
                return View(lista);
        }

        // GET: Actividad/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Actividad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Actividad/Create
        [HttpPost]
        public ActionResult Create(ListActividadViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (mediManContext db = new mediManContext())
                    {
                        var act = new ACTIVIDADES();
                        act.ACTIVIDAD = model.Nombre;


                        db.ACTIVIDADES.Add(act);
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

        // GET: Actividad/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Actividad/Edit/5
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

        // GET: Actividad/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Actividad/Delete/5
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
