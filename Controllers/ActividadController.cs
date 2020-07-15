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
    /// <summary>
    /// Controlador para clase Actividad. Contiene el CRUD.
    /// </summary>
    public class ActividadController : Controller
    {
        // GET: Actividad
        /// <summary>
        /// Muestra las actividades registradas en la BD
        /// </summary>
        /// <returns>Listado de actividades registradas en el sistema</returns>
        public ActionResult Index()
        {
            try
            {
                using (mediManContext db = new mediManContext())
                {
                    return View(db.ACTIVIDADES.ToList());
                }
            }
            catch (Exception)
            {
                throw;
            }
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
        /// <summary>
        /// Método crear
        /// </summary>
        /// <param name="model">Datos ingresados por usuario</param>
        /// <returns>Registra una nueva actividad</returns>
        [HttpPost]
        public ActionResult Create(ACTIVIDADES model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (mediManContext db = new mediManContext())
                    {
                        var act = new ACTIVIDADES();
                        act.ACTIVIDAD = model.ACTIVIDAD;


                        db.ACTIVIDADES.Add(act);
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

        // GET: Actividad/Edit/5
        /// <summary>
        /// Método editar
        /// </summary>
        /// <param name="id">Identificador del registro seleccionado</param>
        /// <returns>Muestra el detalle de la actividad seleccionada</returns>
        public ActionResult Edit(int id)
        {
            using (mediManContext db = new mediManContext())
            {
                ACTIVIDADES act = db.ACTIVIDADES.Find(id);
                return View(act);
            }
        }

        // POST: Actividad/Edit/5
        /// <summary>
        /// Método editar, envía los cambios realizados al registro
        /// </summary>
        /// <param name="model">Datos ingresados por el usuario</param>
        /// <returns>Actualiza los cambios realizados al registro</returns>
        [HttpPost]
        public ActionResult Edit(ACTIVIDADES model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (mediManContext db = new mediManContext())
                    {
                        var act = new ACTIVIDADES();
                        act.ACTIVIDAD = model.ACTIVIDAD;


                        db.ACTIVIDADES.Add(act);
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

        // GET: Actividad/Delete/5
        /// <summary>
        /// Método eliminar
        /// </summary>
        /// <param name="id">Identificador del registro seleccionado</param>
        /// <returns>Elimina el registro y actualiza el listado</returns>
        public ActionResult Delete(int id)
        {
            using (mediManContext db = new mediManContext())
            {
                ACTIVIDADES act = db.ACTIVIDADES.Find(id);
                db.ACTIVIDADES.Remove(act);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
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
