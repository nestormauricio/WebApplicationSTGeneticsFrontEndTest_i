using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationSTGeneticsFrontEndTest_i.Datos;
using WebApplicationSTGeneticsFrontEndTest_i.Modelos;

namespace WebApplicationSTGeneticsFrontEndTest_i.Pages.Animales
{
    public class EditarModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;
        public EditarModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        [BindProperty]
        public Animal Animal { get; set; }
        //[TempData]
        //public string Mensaje { get; set; }
        public async void OnGet(int id)
        {
#pragma warning disable CS8601 // Posible asignación de referencia nula
            Animal = await _contexto.Animal.FindAsync(id);
#pragma warning restore CS8601 // Posible asignación de referencia nula
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //return Page();
                var AnimalDesdeBD = await _contexto.Animal.FindAsync(Animal.AnimalId);
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
                AnimalDesdeBD.Name = Animal.Name;
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
                AnimalDesdeBD.Breed = Animal.Breed;
                AnimalDesdeBD.BirthDate = Animal.BirthDate;
                AnimalDesdeBD.Sex = Animal.Sex;
                AnimalDesdeBD.Price = Animal.Price;
                AnimalDesdeBD.Status = Animal.Status;

                await _contexto.SaveChangesAsync();
                //Mensaje = "Animal editado exitosamente";
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
//            Animal = await _contexto.Animal.FindAsync(id);