﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaMediMan.Models;
using SistemaMediMan.Models.ViewModels;

namespace SistemaMediMan.Controllers
{
    public class FichaController : Controller
    {
        private mediManContext db = new mediManContext();

        // GET: Ficha
        public ActionResult Index()
        {
            try
            {
                using (mediManContext db = new mediManContext())
                {
                    return View(db.FICHAS.ToList());
                }
            }
            catch (Exception)
            {
                throw;
            }
            /*List<ListFichaViewModel> lista;
            using (mediManContext db = new mediManContext())
            {
                lista = (from d in db.FICHAS
                         select new ListFichaViewModel
                         {
                             Id = d.ID,
                             Medico = d.MEDICO,
                             Tratamiento=d.TRATAMIENTO,
                             Diagnostico=d.DIAGNOSTICO,
                             Medicamento=d.MEDICAMENTO,
                             AntMorbido=d.ANTMORBIDO,
                             Paciente_id=d.PAC_ID,

                         }).ToList();
            }
            return View(lista);*/
        }

        // GET: Ficha/Details/5
        public ActionResult Details(int id)
        {
            
            return View();
        }

        // GET: Ficha/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ficha/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ListFichaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (mediManContext db = new mediManContext())
                    {
                        var fi = new FICHAS();
                        fi.MEDICO = model.Medico;
                        fi.TRATAMIENTO = model.Tratamiento;
                        fi.DIAGNOSTICO = model.Diagnostico;
                        fi.MEDICAMENTO = model.Medicamento;
                        fi.ANTMORBIDO = model.AntMorbido;
                        fi.PAC_ID = model.Paciente_id;

                        db.FICHAS.Add(fi);
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

        // GET: Ficha/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View();
        }

        // POST: Ficha/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ListFichaViewModel model)
        { 
            return View();
        }

        // GET: Ficha/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ficha/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
