using SistemaMediMan.Models;
using SistemaMediMan.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaMediMan.Controllers
{
    /// <summary>
    /// Controlador para clase Deporte. Contiene el CRUD.
    /// </summary>
    public class DeporteController : Controller
    {
        // GET: Deporte
        /// <summary>
        /// Muestra los deportes registrados en la BD
        /// </summary>
        /// <returns>Listado de deportes registrados en el sistema</returns>
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
        /// <summary>
        /// Método crear
        /// </summary>
        /// <param name="model">Datos ingresados por usuario</param>
        /// <returns>Registra un nuevo deporte</returns>
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
        /// <summary>
        /// Método editar
        /// </summary>
        /// <param name="id">Identificador del registro seleccionado</param>
        /// <returns>Muestra el detalle del deporte seleccionada</returns>
        public ActionResult Edit(int id)
        {
            using (mediManContext db = new mediManContext())
            {
                DEPORTES dep = db.DEPORTES.Find(id);
                return View(dep);
            }
        }

        // POST: Deporte/Edit/5
        /// <summary>
        /// Método editar, envía los cambios realizados al registro
        /// </summary>
        /// <param name="model">Datos ingresados por el usuario</param>
        /// <returns>Actualiza los cambios realizados al registro</returns>
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
        /// <summary>
        /// Método eliminar
        /// </summary>
        /// <param name="id">Identificador del registro seleccionado</param>
        /// <returns>Elimina el registro y actualiza el listado</returns>
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
