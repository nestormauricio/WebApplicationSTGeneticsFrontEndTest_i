using System.ComponentModel.DataAnnotations;

namespace WebApplicationSTGeneticsFrontEndTest_i.Modelos
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Breed")]
        public string Breed { get; set; }
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Sex")]
        public string Sex { get; set; }
        [Display(Name = "Price")]
        public int Price { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
