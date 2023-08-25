using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PJLeonardoMachado.Models
{
    public class Psico : IdentityUser
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string CRM { get; set; }
        public string Especialidade { get; set; }

    }
}
