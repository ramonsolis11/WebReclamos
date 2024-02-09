using Microsoft.AspNetCore.Mvc;
using WebReclamos.Models;
using WebReclamos.Services; // Asegúrate de tener un espacio de nombres para tus servicios

public class ReclamoController : Controller
{
    private readonly ISapServiceLayerClient _sapService;

    public ReclamoController(ISapServiceLayerClient sapService)
    {
        _sapService = sapService;
    }

    [HttpGet]
    public IActionResult NuevoReclamo()
    {
        return View(new Reclamo()); // Inicializa un nuevo modelo para la vista
    }

    [HttpPost]
    [ValidateAntiForgeryToken] // Protección contra ataques de falsificación de solicitud entre sitios
    public async Task<IActionResult> NuevoReclamo(Reclamo model)
    {
        if (ModelState.IsValid)
        {
            try
            {
                // Lógica para enviar los datos a SAP Business One
                var resultado = await _sapService.EnviarReclamoAsync(model);
                if (resultado)
                {
                    return RedirectToAction("Confirmacion");
                }
                else
                {
                    // Manejar la situación donde SAP no procesa el reclamo
                    ModelState.AddModelError(string.Empty, "Hubo un problema al enviar el reclamo a SAP.");
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                ModelState.AddModelError(string.Empty, "Ocurrió un error inesperado.");
            }
        }
        return View(model);
    }
}

