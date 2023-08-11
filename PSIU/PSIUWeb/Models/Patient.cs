using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSIUWeb.Models
{
    public enum Race {
        Asiático,
        Branco,
        Indio,
        Negro,
        Pardo,
        Outros
    }
        
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Requirido")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Data de Nascimento Requirida")]
        [Display(BirthDate = "Data de Nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Peso Requirido")]
        [Display(Weight = "Peso")]
        public float Weight { get; set; }
        // Float, decimal são tipos reais

        [Required(ErrorMessage = "Altura Requirida")]
        [Display(Height = "Altura")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Raça Requirida")]
        [Display(Race = "Raça")]
        public Race Race { get; set; }

        [ForeignKey("User")]
        public string UserID { get; set; }
        //Navigation 
        public appUser User { get; set; }

    }
}
