using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaMediMan.Models;
using SistemaMediMan.Models.ViewModels;

namespace SistemaMediMan.Controllers
{
    /// <summary>
    /// Controlador para clase Empleado. Contiene el CRUD.
    /// </summary>
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        /// <summary>
        /// Muestra los datos de los empleados registrados
        /// </summary>
        /// <returns>Listado de los empleados registrados en el sistema</returns>
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
        /// <summary>
        /// Método crear
        /// </summary>
        /// <param name="model">Datos ingresados por usuario</param>
        /// <returns>Registra un nuevo empleado</returns>
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
        /// <summary>
        /// Método editar, obtiene los datos del empleado seleccionado
        /// </summary>
        /// <param name="id">Identificador del registro seleccionado</param>
        /// <returns>Muestra los datos del empleado seleccionado</returns>
        public ActionResult Edit(int id)
        {
            using (mediManContext db = new mediManContext())
            {
                EMPLEADOS e = db.EMPLEADOS.Find(id);
                return View(e);
            }
        }

        // POST: Deporte/Edit/5
        /// <summary>
        /// Método editar, envía los cambios realizados al registro
        /// </summary>
        /// <param name="model">Datos ingresados por el usuario</param>
        /// <returns>Actualiza los cambios realizados al registro</returns>
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
        /// <summary>
        /// Método eliminar
        /// </summary>
        /// <param name="id">Identificador del registro seleccionado</param>
        /// <returns>Elimina el registro y actualiza el listado</returns>
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
        public ActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// Control de login.
        /// </summary>
        /// <param name="User"></param>
        /// <param name="Pass"></param>
        /// <returns>Permite acceso a sesión.</returns>
        [HttpPost]
        public ActionResult Login(string User, string Pass)
        {
            try
            {
                using (mediManContext db = new mediManContext())
                {
                    var Us = (from d in db.EMPLEADOS
                              where d.USER == User.Trim() && d.PASS == Pass.Trim()
                              select d).FirstOrDefault();
                    if (Us == null)
                    {
                        ViewBag.ErrorMessage = "Usuario o Contraseña incorrectos";
                        return View();
                    }
                    Session["User"] = Us;
                }
                return RedirectToAction("Index","Consult"); //reenviar vista calendario
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Ha ocurrido un error inesperado " + e.Message);
                return View();
            }
        }
    }

}