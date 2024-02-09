using Microsoft.AspNetCore.Mvc;
using WebReclamos.Models;

public class ReclamoController : Controller
{
    [HttpGet]
    public ActionResult NuevoReclamo()
    {
        return View();
    }

    [HttpPost]
    public ActionResult NuevoReclamo(Reclamo model)
    {
        if (ModelState.IsValid)
        {
            // Lógica para enviar los datos a SAP Business One
            return RedirectToAction("ReclamoEnviado");

        }
        return View(model);
    }

}

