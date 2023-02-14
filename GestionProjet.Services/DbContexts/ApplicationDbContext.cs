using GestionProjet.Services.ProjectAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionProjet.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions option) : base(option)
        {
            
        }

        public DbSet<Employe> Employes { get; set; }
    }
}
