using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PJLeonardoMachado.Models;

namespace PJLeonardoMachado.Data
{
    public class appDbContext :
        IdentityDbContext<Psico>
    {
        public appDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Psico> Psicos { get; set; }
    }
}

