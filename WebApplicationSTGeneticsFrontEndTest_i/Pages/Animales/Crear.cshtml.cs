using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationSTGeneticsFrontEndTest_i.Datos;
using WebApplicationSTGeneticsFrontEndTest_i.Modelos;

namespace WebApplicationSTGeneticsFrontEndTest_i.Pages.Animales
{
    public class CrearModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;
        public CrearModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        [BindProperty]
        public Animal Animal { get; set; }
        //[TempData]
        //public string Mensaje { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Animal.BirthDate = DateTime.Now;
            _contexto.Add(Animal);
            await _contexto.SaveChangesAsync();
            //Mensaje = "Animal creado exitosamente";
            return RedirectToPage("Index");
        }
    }
}
