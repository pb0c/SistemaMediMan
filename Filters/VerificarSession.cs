using SistemaMediMan.Controllers;
using SistemaMediMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaMediMan.Filters
{
    /// <summary>
    /// Filtro que permite verificar sesión válida.
    /// </summary>
    public class VerificarSession : ActionFilterAttribute
    {
        private EMPLEADOS Us;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                base.OnActionExecuting(filterContext);
                Us = (EMPLEADOS)HttpContext.Current.Session["User"];
                if (Us == null)
                {
                    if (filterContext.Controller is EmpleadoController == false)
                    {
                        filterContext.HttpContext.Response.Redirect("/Empleado/Login");
                    }
                }
            }
            catch (Exception)
            {
                filterContext.Result = new RedirectResult("~/Empleado/Login");
            }
            
        }
    }
}