using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CRUD.Models;

namespace CRUD.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult listar() {

            List<Personas> oListarPersonas = new List<Personas>();
            using (Model db = new Model())
            {
                oListarPersonas = (from p in db.Personas select p).ToList();
            }

            return Json(new { data = oListarPersonas }, JsonRequestBehavior.AllowGet);
        }

    }
}