using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationSTGeneticsFrontEndTest_i.Datos;
using WebApplicationSTGeneticsFrontEndTest_i.Modelos;

namespace WebApplicationSTGeneticsFrontEndTest_i.Pages.Animales
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public IndexModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public IEnumerable<Animal> Animales { get; set; }
        //public string Mensaje { get; set; }
        public async Task OnGet()
        {
            Animales = await _contexto.Animal.ToListAsync();
        }
        public async Task<IActionResult> OnPostBorrar(int id)
        {
            var animal = await _contexto.Animal.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }
            _contexto.Animal.Remove(animal);
            await _contexto.SaveChangesAsync();
            //Mensaje = "Animal borrado exitosamente";
            return RedirectToPage("Index");
        }
    }
}
