using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PSIUWeb.Models
{
    public enum Gender { Feminino, Masculino, Outros }
    public class appUser : IdentityUser
    {
        [Required(ErrorMessage = "Nome requirido!")]
        [Display(Name = "Nome completo.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Data de nascimento requirido!")]
        [Display(Name = "Data de nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Genêro requerido")]
        [Display(Name = "Gênero")]
        public Gender Gender { get; set; }
        public DateTime? CreatinDate { get; set;}

    }
}
