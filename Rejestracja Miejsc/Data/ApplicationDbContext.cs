using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rejestracja_Miejsc.Models;

namespace Rejestracja_Miejsc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Rejestracja_Miejsc.Models.Show>? Show { get; set; }
        public DbSet<Rejestracja_Miejsc.Models.Reservation>? Reservation { get; set; }
    }
}