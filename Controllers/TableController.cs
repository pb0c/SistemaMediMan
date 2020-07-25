using SistemaMediMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaMediMan.Controllers
{
    public class TableController : Controller
    {
        // GET: Table
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEvents()
        {
            using (mediManContext db = new mediManContext())
            {
                var events = db.Table.ToList();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }
    }
}