using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using MusicApp.Core.Entities;

namespace MusicApp.Infrastructure
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> dbContextOptions)
            :base(dbContextOptions)
        {
        }
        public DbSet<Zaposlenik> Zaposlenik { get; set; }
        public DbSet<Kategorija> Kategorija{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zaposlenik>().HasOne(x => x.Kategorija).WithMany(d => d.Zaposleniks).HasForeignKey(x => x.KategorijaId);

            OnModelCreatingPartial(modelBuilder);
        }
        private void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategorija>().HasData(
                new Kategorija()
                {
                    Id = 1,
                    Name = "Editor"
                },
                new Kategorija()
                {
                    Id = 2,
                    Name = "Project Manager"
                },
                          new Kategorija()
                          {
                              Id = 3,
                              Name = "Supervisor"
                          },
                               new Kategorija()
                               {
                                   Id = 4,
                                   Name = "Assistant"
                               }

            );
            modelBuilder.Entity<Zaposlenik>().HasData(
              new Zaposlenik
              {
                  Id = 1,
                  Ime = "Lose Urself",
                  Adresa = "https://www.youtube.com/watch?v=_Yhyp-_hX2s",
                  Jmbg = "Eminem",
                  KategorijaId = 1,
                  ModifiedAt = new DateTime(2021 - 11 - 20),
                  CreatedAt = new DateTime(2021 - 11 - 20),
                  Aktivan = true,
                  GodinaZaposlenja = 5
              }
              );
        }
    }
}
