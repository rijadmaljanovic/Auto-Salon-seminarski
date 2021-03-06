// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicApp.Infrastructure;

namespace Auto_salon.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220322164152_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicApp.Core.Entities.Kategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategorija");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Editor"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Project Manager"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Supervisor"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Assistant"
                        });
                });

            modelBuilder.Entity("MusicApp.Core.Entities.Zaposlenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("GodinaZaposlenja")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Jmbg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Zaposlenik");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adresa = "https://www.youtube.com/watch?v=_Yhyp-_hX2s",
                            Aktivan = true,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990),
                            GodinaZaposlenja = 5,
                            Ime = "Lose Urself",
                            Jmbg = "Eminem",
                            KategorijaId = 1,
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1990)
                        });
                });

            modelBuilder.Entity("MusicApp.Core.Entities.Zaposlenik", b =>
                {
                    b.HasOne("MusicApp.Core.Entities.Kategorija", "Kategorija")
                        .WithMany("Zaposleniks")
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategorija");
                });

            modelBuilder.Entity("MusicApp.Core.Entities.Kategorija", b =>
                {
                    b.Navigation("Zaposleniks");
                });
#pragma warning restore 612, 618
        }
    }
}
