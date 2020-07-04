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
        public ActionResult Create(ListEmpleadoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (mediManContext db = new mediManContext())
                    {
                        var emp = new EMPLEADOS();
                        emp.RUT = model.Rut;
                        emp.NOMBRE = model.Nombre;
                        emp.APELLIDOP = model.ApellidoP;
                        emp.APELLIDOM = model.ApellidoM;
                        emp.TELEFONO = model.Telefono;
                        emp.ROL = model.Rol;
                        emp.USER = model.User;
                        emp.PASS = model.Pass;

                        db.EMPLEADOS.Add(emp);
                        db.SaveChanges();
                    }
                    return RedirectToAction("/");
                }
                return View(model);
                
            }
            catch(Exception e)
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