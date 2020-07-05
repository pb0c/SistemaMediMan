using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaMediMan.Models;
using SistemaMediMan.Models.ViewModels;

namespace SistemaMediMan.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            try
            {
                using (mediManContext db = new mediManContext())
                {
                    return View(db.EMPLEADOS.ToList());
                }
            }
            catch (Exception)
            {
                throw;
            }
            /*List<ListEmpleadoViewModel> lista;
            using (mediManContext db = new mediManContext())
            {
                lista = (from d in db.EMPLEADOS
                         select new ListEmpleadoViewModel
                         {
                             Id = d.ID,
                             Rut = d.RUT,
                             Nombre = d.NOMBRE,
                             ApellidoP = d.APELLIDOP,
                             ApellidoM = d.APELLIDOM,
                             Telefono = d.TELEFONO,
                             Rol = d.ROL,
                             User = d.USER,
                             Pass = d.PASS,

                         }).ToList();
            }
            return View(lista);*/
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
        public ActionResult Create(EMPLEADOS model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (mediManContext db = new mediManContext())
                    {
                        var emp = new EMPLEADOS();
                        emp.RUT = model.RUT;
                        emp.NOMBRE = model.NOMBRE;
                        emp.APELLIDOP = model.APELLIDOP;
                        emp.APELLIDOM = model.APELLIDOM;
                        emp.ROL = model.ROL;
                        emp.TELEFONO = model.TELEFONO;
                        emp.USER = model.USER;
                        emp.PASS = model.PASS;

                        db.EMPLEADOS.Add(emp);
                        db.SaveChanges();
                    }
                    return Redirect("Index/");
                }
                return View(model);
                
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", "Error de registro " + e.Message);
                return View();

            }
        }

        // GET: Deporte/Edit/5
        public ActionResult Edit(int id)
        {
            using (mediManContext db = new mediManContext())
            {
                EMPLEADOS e = db.EMPLEADOS.Find(id);
                return View(e);
            }
        }

        // POST: Deporte/Edit/5
        [HttpPost]
        public ActionResult Edit(EMPLEADOS model)
        {
            try
            {
                using (mediManContext db = new mediManContext())
                {
                    EMPLEADOS emp = db.EMPLEADOS.Find(model.ID);
                    emp.RUT = model.RUT;
                    emp.NOMBRE = model.NOMBRE;
                    emp.APELLIDOP = model.APELLIDOP;
                    emp.APELLIDOM = model.APELLIDOM;
                    emp.ROL = model.ROL;
                    emp.TELEFONO = model.TELEFONO;
                    emp.USER = model.USER;
                    emp.PASS = model.PASS;
                    

                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
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
                EMPLEADOS emp = db.EMPLEADOS.Find(id);
                db.EMPLEADOS.Remove(emp);
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

        //Queda pendiente verificación de contraseña (crear y editar)
    }

}