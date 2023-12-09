using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Coptil_Ianc_Proiect1.Models;

namespace Coptil_Ianc_Proiect1.Data
{
    public class AdapostContext : IdentityDbContext<IdentityUser>
    {
        public AdapostContext(DbContextOptions<AdapostContext> options)
           : base(options)
        {
        }

        public DbSet<Camera> Camera { get; set; }
        public DbSet<Programare> Programare { get; set;}
        public DbSet<TipCamera> TipCamera { get; set; }
        public DbSet<TipHrana> TipHrana { get; set; }
        public DbSet<Recenzie> Recenzie { get; set; }
        public DbSet<Coptil_Ianc_Proiect1.Models.TipServiciu>? TipServiciu { get; set; }
    }
}
