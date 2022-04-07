using Data_AS.EntityModels;
using Data_AS.EntityModels.Korisnici;
using Data_AS.EntityModels.Vozila;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<Korisnik>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Korisnik>()

            .HasOne<Zaposlenik>(s => s.Zaposlenik)

            .WithOne(ad => ad.Korisnik)

            .HasForeignKey<Zaposlenik>(ad => ad.KorisnikId);

            modelBuilder.Entity<Korisnik>()

            .HasOne<Administrator>(s => s.Administrator)

            .WithOne(ad => ad.Korisnik)

            .HasForeignKey<Administrator>(ad => ad.KorisnikId);

            modelBuilder.Entity<Korisnik>()

           .HasOne<Klijent>(s => s.Klijent)

           .WithOne(ad => ad.Korisnik)

           .HasForeignKey<Klijent>(ad => ad.KorisnikId);

            modelBuilder.Entity<Nabavka>()
               .HasIndex(n => n.VoziloId)
               .IsUnique();


        }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Klijent> Klijent { get; set; }
        public DbSet<Zaposlenik> Zaposlenik { get; set; }
        public DbSet<Nabavka> Nabavka { get; set; }
        public DbSet<Notifikacija> Notifikacija { get; set; }
        public DbSet<Boja> Boja { get; set; }
        public DbSet<BrojStepeniPrijenosa> BrojStepeniPrijenosa { get; set; }
        public DbSet<BrojVrata> BrojVrata { get; set; }
        public DbSet<EmisioniStandard> EmisioniStandard { get; set; }
        public DbSet<GodinaProizvodnje> GodinaProizvodnje { get; set; }
        public DbSet<Gorivo> Gorivo { get; set; }
        public DbSet<ModelVozila> ModelVozila { get; set; }
        public DbSet<ParkingSenzor> ParkingSenzor { get; set; }
        public DbSet<Pogon> Pogon { get; set; }
        public DbSet<TipVozila> TipVozila { get; set; }
        public DbSet<Transmisija> Transmisija { get; set; }
        public DbSet<Vozilo> Vozilo { get; set; }
        public DbSet<VrstaKaroserije> VrstaKaroserije { get; set; }
        public DbSet<VrstaKlime> VrstaKlime { get; set; }
        public DbSet<VrstaMotora> VrstaMotora { get; set; }
        public DbSet<VrstaSvjetla> VrstaSvjetla { get; set; }
        public DbSet<VoziloFavorit> VoziloFavorit { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<VoziloImage> VoziloImage { get; set; }
        private void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Boja>().HasData(
                new Boja()
                {
                    Id = 1,
                    Naziv = "Plava"
                },
                new Boja()
                {
                    Id = 2,
                    Naziv = "Zelena"
                },
                new Boja()
                {
                    Id = 3,
                    Naziv = "Crna"
                }
                );
            modelBuilder.Entity<BrojStepeniPrijenosa>().HasData(
                new BrojStepeniPrijenosa()
                {
                    Id = 1,
                    Naziv = "Sedam"
                },
                new BrojStepeniPrijenosa()
                {
                    Id = 2,
                    Naziv = "Sest"
                },
                new BrojStepeniPrijenosa()
                {
                    Id = 3,
                    Naziv = "Pet"
                }
                );
            modelBuilder.Entity<BrojVrata>().HasData(
                new BrojVrata()
                {
                    Id = 1,
                    Naziv = "Sedam"
                },
                new BrojVrata()
                {
                    Id = 2,
                    Naziv = "Sest"
                },
                new BrojVrata()
                {
                    Id = 3,
                    Naziv = "Pet"
                }
                );
            modelBuilder.Entity<EmisioniStandard>().HasData(
                new EmisioniStandard()
                {
                    Id = 1,
                    Naziv = "ES5"
                },
                new EmisioniStandard()
                {
                    Id = 2,
                    Naziv = "ES6"
                },
                new EmisioniStandard()
                {
                    Id = 3,
                    Naziv = "ES7"
                }
                );
            modelBuilder.Entity<GodinaProizvodnje>().HasData(
               new GodinaProizvodnje()
               {
                   Id = 1,
                   Godina = 2000
               },
               new GodinaProizvodnje()
               {
                   Id = 2,
                   Godina = 2001
               },
               new GodinaProizvodnje()
               {
                   Id = 3,
                   Godina = 2002
               },
                new GodinaProizvodnje()
                {
                    Id = 3,
                    Godina = 2005
                },
                 new GodinaProizvodnje()
                 {
                     Id = 3,
                     Godina = 2010
                 },
                  new GodinaProizvodnje()
                  {
                      Id = 3,
                      Godina = 2020
                  },
                   new GodinaProizvodnje()
                   {
                       Id = 3,
                       Godina = 2002
                   }
               );
            modelBuilder.Entity<Gorivo>().HasData(
                new Gorivo()
                {
                    Id = 1,
                    Naziv = "Dizel"
                },
                new Gorivo()
                {
                    Id = 2,
                    Naziv = "Benzin"
                },
                new Gorivo()
                {
                    Id = 3,
                    Naziv = "Plin"
                }
                );
            modelBuilder.Entity<ModelVozila>().HasData(
                new ModelVozila()
                {
                    Id = 1,
                    Naziv = "Mercedes"
                },
                new ModelVozila()
                {
                    Id = 2,
                    Naziv = "BMW"
                },
                new ModelVozila()
                {
                    Id = 3,
                    Naziv = "Volkswagen"
                },
                new ModelVozila()
                {
                    Id = 2,
                    Naziv = "Fiat"
                },
                new ModelVozila()
                {
                    Id = 2,
                    Naziv = "Dacia"
                },
                new ModelVozila()
                {
                    Id = 2,
                    Naziv = "Seat"
                }
                );
            modelBuilder.Entity<ParkingSenzor>().HasData(
               new ParkingSenzor()
               {
                   Id = 1,
                   Naziv = "Prednji"
               },
               new ParkingSenzor()
               {
                   Id = 2,
                   Naziv = "Zadnji"
               },
               new ParkingSenzor()
               {
                   Id = 3,
                   Naziv = "Prednji i zadnji"
               }
               );
            modelBuilder.Entity<Pogon>().HasData(
               new Pogon()
               {
                   Id = 1,
                   Naziv = "Prednji"
               },
               new Pogon()
               {
                   Id = 2,
                   Naziv = "Zadnji"
               },
               new Pogon()
               {
                   Id = 3,
                   Naziv = "Prednji i zadnji"
               }
               );
            modelBuilder.Entity<TipVozila>().HasData(
               new TipVozila()
               {
                   Id = 1,
                   Naziv = "Terenac"
               },
               new TipVozila()
               {
                   Id = 2,
                   Naziv = "Skuter"
               },
               new TipVozila()
               {
                   Id = 3,
                   Naziv = "Auto"
               },
               new TipVozila()
               {
                   Id = 3,
                   Naziv = "Kombi"
               },
               new TipVozila()
               {
                   Id = 3,
                   Naziv = "Kamion"
               }
               );
            modelBuilder.Entity<Transmisija>().HasData(
               new Transmisija()
               {
                   Id = 1,
                   Naziv = "Manual"
               },
               new Transmisija()
               {
                   Id = 2,
                   Naziv = "Automatik"
               },
               new Transmisija()
               {
                   Id = 3,
                   Naziv = "Poluautomatik"
               }
               );
            modelBuilder.Entity<VrstaKaroserije>().HasData(
             new VrstaKaroserije()
             {
                 Id = 1,
                 Naziv = "Limuzina"
             },
             new VrstaKaroserije()
             {
                 Id = 2,
                 Naziv = "Dzip"
             },
             new VrstaKaroserije()
             {
                 Id = 3,
                 Naziv = "Karavan"
             }
             );
            modelBuilder.Entity<VrstaKlime>().HasData(
            new VrstaKlime()
            {
                Id = 1,
                Naziv = "Dvosezonska"
            },
            new VrstaKlime()
            {
                Id = 2,
                Naziv = "Cetverosezonska"
            },
            new VrstaKlime()
            {
                Id = 3,
                Naziv = "Jednosezonska"
            }
            );
            modelBuilder.Entity<VrstaMotora>().HasData(
            new VrstaMotora()
            {
                Id = 1,
                Naziv = "V6"
            },
            new VrstaMotora()
            {
                Id = 2,
                Naziv = "V4"
            },
            new VrstaMotora()
            {
                Id = 3,
                Naziv = "V8"
            }
            );
            modelBuilder.Entity<VrstaSvjetla>().HasData(
            new VrstaSvjetla()
            {
                Id = 1,
                Naziv = "Xenon"
            },
            new VrstaSvjetla()
            {
                Id = 2,
                Naziv = "Led"
            },
            new VrstaSvjetla()
            {
                Id = 3,
                Naziv = "Obicna"
            }
            );
        }
    }
}
