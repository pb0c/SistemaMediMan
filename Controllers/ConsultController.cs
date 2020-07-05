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
            return View();
        }

        // POST: Consult/Edit/5
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

        // GET: Consult/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
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
            return View(new ListConsultaViewModel());
        }

        public JsonResult GetEvents(DateTime start)
        {
            var viewModel = new ListConsultaViewModel();
            var events = new List<ListConsultaViewModel>();
            start = DateTime.Today.AddDays(-14);
            
            events.Add(new ListConsultaViewModel()
                {
                    Box = viewModel.Box,
                    FechaHora = viewModel.FechaHora,
                    Sesion = viewModel.Sesion,
                    Paciente_id = viewModel.Paciente_id,
                    Empleado_id = viewModel.Empleado_id,
                });

                start = start.AddDays(7);

            return Json(events.ToArray(), JsonRequestBehavior.AllowGet);
        }


    }
}
