using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using SistemaMediMan.Models;
using SistemaMediMan.Models.ViewModels;

namespace SistemaMediMan.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Index()
        {
            try
            {
                using (mediManContext db = new mediManContext())
                {
                    return View(db.PACIENTES.ToList());
                }
            }
            catch(Exception)
            {
                throw;
            }
            /*List<ListPacienteViewModel> lista;
            using(mediManEntities db = new mediManEntities())
            {
                lista = (from d in db.PACIENTES
                         select new ListPacienteViewModel
                         {
                             Id = d.ID,
                             Rut = d.RUT,
                             Nombre = d.NOMBRE,
                             ApellidoP = d.APELLIDOP,
                             ApellidoM = d.APELLIDOM,
                             Fdenac = d.FDENAC,
                             Edad = d.EDAD,
                             Sexo = d.SEXO,
                             Telefono = d.TELEFONOP,
                             Prevision=d.PREVISION,
                             Calle = d.CALLE,
                             Numero=d.NUMCALLE,
                             Dpto = d.DPTO,
                             Comuna=d.COMUNA,

                         }).ToList() ;
            }
            return View(lista);*/
        }

        // GET: Paciente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Paciente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Paciente/Create
        [HttpPost]
        public ActionResult Create(PACIENTES model)

        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (mediManContext db = new mediManContext())
                    {
                        var pac = new PACIENTES();
                        pac.RUT = model.RUT;
                        pac.NOMBRE = model.NOMBRE;
                        pac.APELLIDOP = model.APELLIDOP;
                        pac.APELLIDOM = model.APELLIDOM;
                        pac.FDENAC = model.FDENAC;
                        pac.EDAD = model.EDAD;
                        pac.SEXO = model.SEXO;
                        pac.TELEFONOP = model.TELEFONOP;
                        pac.PREVISION = model.PREVISION;
                        pac.CALLE = model.CALLE;
                        pac.NUMCALLE = model.NUMCALLE;
                        pac.DPTO = model.DPTO;
                        pac.COMUNA = model.COMUNA;
                        pac.ACT_ID = model.ACT_ID;
                        pac.DEP_ID = model.DEP_ID;


                        db.PACIENTES.Add(pac);
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

        // GET: Paciente/Edit/5
        public ActionResult Edit(int id)
        {
            using (mediManContext db = new mediManContext())
            {
                PACIENTES p = db.PACIENTES.Find(id);
                return View(p);
            }
            
        }

        // POST: Paciente/Edit/5
        [HttpPost]
        public ActionResult Edit(PACIENTES model)
        {
            try
            {
                using (mediManContext db = new mediManContext())
                {
                    PACIENTES pac = db.PACIENTES.Find(model.ID);
                    pac.RUT = model.RUT;
                    pac.NOMBRE = model.NOMBRE;
                    pac.APELLIDOP = model.APELLIDOP;
                    pac.APELLIDOM = model.APELLIDOM;
                    pac.FDENAC = model.FDENAC;
                    pac.EDAD = model.EDAD;
                    pac.SEXO = model.SEXO;
                    pac.TELEFONOP = model.TELEFONOP;
                    pac.PREVISION = model.PREVISION;
                    pac.CALLE = model.CALLE;
                    pac.NUMCALLE = model.NUMCALLE;
                    pac.DPTO = model.DPTO;
                    pac.COMUNA = model.COMUNA;
                    pac.ACT_ID = model.ACT_ID;
                    pac.DEP_ID = model.DEP_ID;

                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", "Error al actualizar " + e.Message);
                return View();
            }
        }

        // GET: Paciente/Delete/5
        public ActionResult Delete(int id)
        {
            using (mediManContext db = new mediManContext())
            {
                PACIENTES p = db.PACIENTES.Find(id);
                db.PACIENTES.Remove(p);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        // POST: Paciente/Delete/5
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

        //Listar actividades para vista parcial
        public ActionResult ListaAct()
        {
            using (var db = new mediManContext())
            {
                return PartialView(db.ACTIVIDADES.ToList());
            }
        }

        //Listar deportes para vista parcial
        public ActionResult ListaDep()
        {
            using (var db = new mediManContext())
            {
                return PartialView(db.DEPORTES.ToList());
            }
        }

        public static string NomAct(int ACT_ID)
        {
            using (mediManContext db = new mediManContext())
            {
              return db.ACTIVIDADES.Find(ACT_ID).ACTIVIDAD;
                           
            }
        }

        public static string NomDep(int DEP_ID)
        {
            using (mediManContext db = new mediManContext())
            {
                return db.DEPORTES.Find(DEP_ID).DEPORTE;
            }
        }

        //DEP_ID guarda ACT_ID, PENDIENTE REVISAR
    }
}
