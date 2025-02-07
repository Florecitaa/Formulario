using System.Web.Mvc;
using Formulario.Models;

namespace Formulario.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario/Index
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Index(FormularioModel model)
        {
            if (ModelState.IsValid)
            {
                
                return View("Validacion", model);
            }

            return View(model);
        }

        public ActionResult Confirmacion(FormularioModel model)
        {
            return View(model);
        }
    }
}