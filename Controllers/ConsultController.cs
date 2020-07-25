using SistemaMediMan.Models;
using SistemaMediMan.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace SistemaMediMan.Controllers
{
    public class ConsultController : Controller
    {
        // GET: Consult
        public ActionResult Index()
        {
            try
            {
                using (mediManContext db = new mediManContext())
                {
                    return View(db.CONSULTAS.ToList());
                }
            }
            catch (Exception)
            {
                throw;
            }
            /*List<ListConsultaViewModel> lista;
            using (mediManContext db = new mediManContext())
            {
                lista = (from d in db.CONSULTAS
                         select new ListConsultaViewModel
                         {
                             Id = d.ID,
                             FechaHora = d.FECHAHORA,
                             Box = d.BOX,
                             Sesion = d.SESION,
                             Paciente_id = d.PAC_ID,
                             Empleado_id = d.EMP_ID,

                         }).ToList();
            }
            return View(lista);*/
        }

        

        // GET: Consult/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Consult/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consult/Create
        [HttpPost]
        public ActionResult Create(CONSULTAS model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (mediManContext db = new mediManContext())
                    {
                        var cons = new CONSULTAS();
                        cons.FECHA = model.FECHA;
                        cons.HORA = model.HORA;
                        cons.BOX = model.BOX;
                        cons.SESION = model.SESION;
                        cons.PAC_ID = model.PAC_ID;
                        cons.EMP_ID = model.EMP_ID;

                        db.CONSULTAS.Add(cons);
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

        // GET: Consult/Edit/5
        public ActionResult Edit(int id)
        {
            using (mediManContext db = new mediManContext())
            {
                CONSULTAS c = db.CONSULTAS.Find(id);
                return View(c);
            }
        }

        // POST: Consult/Edit/5
        [HttpPost]
        public ActionResult Edit(CONSULTAS model)
        {
            try
            {
                using (mediManContext db = new mediManContext())
                {
                    CONSULTAS con = db.CONSULTAS.Find(model.ID);
                    con.PAC_ID = model.PAC_ID;
                    con.EMP_ID = model.EMP_ID;
                    con.FECHA = model.FECHA;
                    con.HORA = model.HORA;
                    con.SESION = model.SESION;
                    con.BOX = model.BOX;
                    
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

        // GET: Consult/Delete/5
        public ActionResult Delete(int id)
        {
            using (mediManContext db = new mediManContext())
            {
                CONSULTAS c = db.CONSULTAS.Find(id);
                db.CONSULTAS.Remove(c);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        // POST: Consult/Delete/5
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

        public ActionResult Calendario()
        {
            return View();
        }

        public JsonResult GetEvents()
        {
            using (mediManContext db = new mediManContext())
            {
                var events = db.CONSULTAS.ToList();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        public static string NomPac(int PAC_ID)
        {
            using (mediManContext db = new mediManContext())
            {
                return db.PACIENTES.Find(PAC_ID).nombreCompleto;

            }
        }
        public static string NomEmp(int EMP_ID)
        {
            using (mediManContext db = new mediManContext())
            {
                return db.EMPLEADOS.Find(EMP_ID).nombreCompleto;

            }
        }

        public ActionResult ListaPac()
        {
            using (var db = new mediManContext())
            {
                return PartialView(db.PACIENTES.ToList());
            }
        }

        public ActionResult ListaEmp()
        {
            using(var db = new mediManContext())
            {
                return PartialView(db.EMPLEADOS.ToList());
            }
        }
    }
}
