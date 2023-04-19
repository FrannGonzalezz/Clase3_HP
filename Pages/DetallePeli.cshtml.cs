using Clase_3.Models;
using Clase_3.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase_3.Pages
{
    public class DetallePeliModel : PageModel
    {
        public Pelicula DetallePeli { get; set; } = new();
        public void OnGet(int codigo)
        {
            if (codigo != null)
            {
                var responseServiceData = ServicioPeli.Get(codigo);
                if (responseServiceData != null)
                {
                    DetallePeli = responseServiceData;
                }
            }
            // var responseServiceData = ServicioPeli.Get(codigo);
            // DetallePeli = responseServiceData;

            // buscar en la página a través del código localhost:
        }

        public IActionResult OnPostDelete(int codigo)
        {
            if (codigo != null)
            {
                ServicioPeli.Eliminar(codigo);
            }
            return RedirectToPage("Peliculas");
        }
    }
}
