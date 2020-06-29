using SistemaMediMan.Models;
using SistemaMediMan.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaMediMan.Controllers
{
    public class ConsultController : Controller
    {
        // GET: Consult
        public ActionResult Index()
        {
            List<ListConsultaViewModel> lista;
            using (mediManEntities db = new mediManEntities())
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
            return View(lista);
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
        public ActionResult Create(ListConsultaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (mediManEntities db = new mediManEntities())
                    {
                        var cons = new CONSULTAS();
                        cons.FECHAHORA = model.FechaHora;
                        cons.BOX = model.Box;
                        cons.SESION = model.Sesion;
                        cons.PAC_ID = model.Paciente_id;
                        cons.EMP_ID = model.Empleado_id;

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
    }
}
