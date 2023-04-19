using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase_3.Pages
{
    public class PeliculasModel : PageModel
    {
        private readonly ILogger<PeliculasModel> _logger;

        public PeliculasModel(ILogger<PeliculasModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
