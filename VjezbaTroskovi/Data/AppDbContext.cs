using Microsoft.EntityFrameworkCore;
using VjezbaTroskovi.Models;

namespace VjezbaTroskovi.Data
{

    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Trosak> Troskovi => Set<Trosak>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Trosak>().HasData(
            new Trosak()
            {
                Id = 1, 
                DatumTroska = DateTime.Now, 
                Opis = "Burek pita", 
                Iznos = 14.5m
            },
            new Trosak()
            {
                Id = 2, 
                DatumTroska = DateTime.Now, 
                Opis = "Sirnica pita", 
                Iznos = 12.3m,
            }
                
            ); 
        }
    }
}
