using Microsoft.EntityFrameworkCore;
using Projekt.Models;

namespace Projekt.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Opcjonalnie: Unikalność (jeśli chcesz mieć po 1 kopii każdej karty)
            modelBuilder.Entity<Card>()
                .HasIndex(c => new { c.PackName, c.CardNumber })
                .IsUnique();

            // Zapełnianie bazy danymi początkowymi (Seeding) z paczki brainrot
            modelBuilder.Entity<Card>().HasData(
                new Card { Id = 1, CardNumber = "001", Name = "BLUBERINI OCTOPUSINI", PackName = "brainrot" },
                new Card { Id = 2, CardNumber = "002", Name = "TIRILICALICA TIRILICALACO", PackName = "brainrot" },
                new Card { Id = 3, CardNumber = "003", Name = "COCCODRILLO FORMAGGIOSO", PackName = "brainrot" },
                new Card { Id = 4, CardNumber = "004", Name = "PANBRONCIO AL LATTE", PackName = "brainrot" },
                new Card { Id = 5, CardNumber = "005", Name = "MARCO POLLO", PackName = "brainrot" },
                new Card { Id = 6, CardNumber = "006", Name = "OCA DEL ROVER LUNARE", PackName = "brainrot" },
                new Card { Id = 7, CardNumber = "007", Name = "GANGSTER FOOTERA", PackName = "brainrot" },
                new Card { Id = 8, CardNumber = "008", Name = "CACTO IPPOPOTAMO", PackName = "brainrot" },
                new Card { Id = 9, CardNumber = "009", Name = "RAPARRAPA CHE PARA", PackName = "brainrot" },
                new Card { Id = 10, CardNumber = "010", Name = "CERVELLO PUDDING", PackName = "brainrot" },
                new Card { Id = 11, CardNumber = "011", Name = "GNAMMO SLAMMO E SGOMMO", PackName = "brainrot" },
                new Card { Id = 12, CardNumber = "012", Name = "AEROMUCCA ARMATA", PackName = "brainrot" },
                new Card { Id = 13, CardNumber = "013", Name = "CAPRAMPANTE SOTTOPANCA", PackName = "brainrot" },
                new Card { Id = 14, CardNumber = "014", Name = "FRULLI FRULLA", PackName = "brainrot" },
                new Card { Id = 15, CardNumber = "015", Name = "CROCODILO POTATINO", PackName = "brainrot" },
                new Card { Id = 16, CardNumber = "016", Name = "BONECA AMBALABU", PackName = "brainrot" },
                new Card { Id = 17, CardNumber = "017", Name = "TRIPPA TROPPA TRALALA LIRI LIRÀ TUNG TUNG SAHUR BONECA TUNG TUNG TRALALELO TRIPPI TROPPA CROCODINA", PackName = "brainrot" },
                new Card { Id = 18, CardNumber = "018", Name = "RUGGINATO LUPOGT", PackName = "brainrot" },
                new Card { Id = 19, CardNumber = "019", Name = "BALLERINO LOLOLO", PackName = "brainrot" },
                new Card { Id = 20, CardNumber = "020", Name = "LA VACCA ATOMO ATOMITA", PackName = "brainrot" }
            );
        }
    }
}