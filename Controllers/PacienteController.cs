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
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Index()
        {
           /* mediManEntities db = new mediManEntities();
            List<PACIENTES> lista = db.PACIENTES.ToList(); */

            List<ListPacienteViewModel> lista;
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
            return View(lista);
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
        public ActionResult Create(ListPacienteViewModel model)

        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (mediManEntities db = new mediManEntities())
                    {
                        var pac = new PACIENTES();
                        pac.RUT = model.Rut;
                        pac.NOMBRE = model.Nombre;
                        pac.APELLIDOP = model.ApellidoP;
                        pac.APELLIDOM = model.ApellidoM;
                        pac.EDAD = model.Edad;
                        pac.SEXO = model.Sexo;
                        pac.TELEFONOP = model.Telefono;
                        pac.PREVISION = model.Prevision;
                        pac.CALLE = model.Calle;
                        pac.NUMCALLE = model.Numero;
                        pac.DPTO = model.Dpto;
                        pac.COMUNA = model.Comuna;


                        db.PACIENTES.Add(pac);
                        db.SaveChanges();
                    }
                    return Redirect("Index/");
                }
                return View(model);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        // GET: Paciente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Paciente/Edit/5
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

        // GET: Paciente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
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
    }
}
