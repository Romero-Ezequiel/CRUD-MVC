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


        public JsonResult Obtener(int idPersonas) {
            Personas oPersonas = new Personas();
            using (Model db = new Model())
            {
                oPersonas = (from p in db.Personas
                             where p.idPersonas == idPersonas select p).FirstOrDefault();
            }

            return Json( oPersonas, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Guardar(Personas oPersona)
        {
            bool respuesta = true;
            try
            {
                if (oPersona.idPersonas == 0)
                {
                    using (Model db = new Model())
                    {
                        db.Personas.Add(oPersona);
                        db.SaveChanges();
                    }
                }
                else
                {
                    using (Model db = new Model())
                    {
                        Personas tempPersona = (from p in db.Personas
                                                where p.idPersonas == oPersona.idPersonas
                                                select p).FirstOrDefault();

                        tempPersona.nombre = oPersona.nombre;
                        tempPersona.apellido = oPersona.apellido;
                        tempPersona.correo = oPersona.correo;

                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                respuesta = false;
            }

            return Json(new { resultado = respuesta }, JsonRequestBehavior.AllowGet);

        }

        public JsonResult Eliminar(int idPersonas)
        {
            bool respuesta = true;
            try
            {
                using (Model db = new Model())
                {
                    Personas oPersona = new Personas();
                    oPersona = (from p in db.Personas.Where(x => x.idPersonas == idPersonas)
                                select p).FirstOrDefault();

                    db.Personas.Remove(oPersona);

                    db.SaveChanges();
                }
            }
            catch
            {
                respuesta = false;
            }

            return Json(new { resultado = respuesta }, JsonRequestBehavior.AllowGet);
        }

    }
}