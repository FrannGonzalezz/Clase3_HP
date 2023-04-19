using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clase_3.Models;
using Clase_3.Servicios;

namespace Clase_3.Pages
{
    public class PeliculasModel : PageModel
    {

        public List<Pelicula> ListaPeliculas { get; set; }


        public PeliculasModel()
        {

        }

        public void OnGet()
        {
            ListaPeliculas = ServicioPeli.GetAll();
        }
    }
}
