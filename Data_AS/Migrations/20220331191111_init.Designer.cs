// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication.Data;

namespace Data_AS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220331191111_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data_AS.EntityModels.Korisnici.Administrator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorisnikId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikId")
                        .IsUnique()
                        .HasFilter("[KorisnikId] IS NOT NULL");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Korisnici.Klijent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnikId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikId")
                        .IsUnique()
                        .HasFilter("[KorisnikId] IS NOT NULL");

                    b.ToTable("Klijent");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Korisnici.Korisnik", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Korisnici.Zaposlenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumZaposlenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("JMBG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnikId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId")
                        .IsUnique()
                        .HasFilter("[KorisnikId] IS NOT NULL");

                    b.ToTable("Zaposlenik");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Nabavka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.Property<DateTime>("DatumNabavke")
                        .HasColumnType("datetime2");

                    b.Property<int>("VoziloId")
                        .HasColumnType("int");

                    b.Property<int>("ZaposlenikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VoziloId")
                        .IsUnique();

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("Nabavka");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Notifikacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Vidjeno")
                        .HasColumnType("bit");

                    b.Property<int>("VoziloFavoritId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VoziloFavoritId");

                    b.ToTable("Notifikacija");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.Boja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Boja");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.BrojStepeniPrijenosa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BrojStepeniPrijenosa");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.BrojVrata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BrojVrata");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.EmisioniStandard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmisioniStandard");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.GodinaProizvodnje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Godina")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GodinaProizvodnje");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.Gorivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gorivo");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PathToImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.ModelVozila", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Duzina_m")
                        .HasColumnType("real");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Tezina_t")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("ModelVozila");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.ParkingSenzor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ParkingSenzor");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.Pogon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pogon");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.TipVozila", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipVozila");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.Transmisija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transmisija");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.Vozilo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ABS")
                        .HasColumnType("bit");

                    b.Property<bool>("Alarm")
                        .HasColumnType("bit");

                    b.Property<bool>("Bluetooth")
                        .HasColumnType("bit");

                    b.Property<int>("BojaId")
                        .HasColumnType("int");

                    b.Property<int>("BrojStepeniPrijenosaId")
                        .HasColumnType("int");

                    b.Property<int>("BrojVrataId")
                        .HasColumnType("int");

                    b.Property<float?>("Cijena")
                        .HasColumnType("real");

                    b.Property<bool>("ESP")
                        .HasColumnType("bit");

                    b.Property<int>("EmisioniStandardId")
                        .HasColumnType("int");

                    b.Property<int>("GodinaProizvodnjeId")
                        .HasColumnType("int");

                    b.Property<int>("GorivoId")
                        .HasColumnType("int");

                    b.Property<float?>("Kubikaza")
                        .HasColumnType("real");

                    b.Property<bool>("Maglenke")
                        .HasColumnType("bit");

                    b.Property<string>("Marka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Mat")
                        .HasColumnType("bit");

                    b.Property<bool>("Metalik")
                        .HasColumnType("bit");

                    b.Property<int?>("ModelId")
                        .HasColumnType("int");

                    b.Property<int>("ParkingSenzorId")
                        .HasColumnType("int");

                    b.Property<int>("PogonId")
                        .HasColumnType("int");

                    b.Property<float?>("PredjeniKilometri")
                        .HasColumnType("real");

                    b.Property<DateTime?>("RegistrovanDo")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SnagaMotoraKS")
                        .HasColumnType("int");

                    b.Property<float?>("SnagaMotoraKW")
                        .HasColumnType("real");

                    b.Property<bool>("Tempomat")
                        .HasColumnType("bit");

                    b.Property<int>("TipVozilaId")
                        .HasColumnType("int");

                    b.Property<int>("TransmisijaId")
                        .HasColumnType("int");

                    b.Property<int>("VrstaKaroserijeId")
                        .HasColumnType("int");

                    b.Property<int>("VrstaKlimeId")
                        .HasColumnType("int");

                    b.Property<int>("VrstaMotoraId")
                        .HasColumnType("int");

                    b.Property<int>("VrstaSvjetlaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BojaId");

                    b.HasIndex("BrojStepeniPrijenosaId");

                    b.HasIndex("BrojVrataId");

                    b.HasIndex("EmisioniStandardId");

                    b.HasIndex("GodinaProizvodnjeId");

                    b.HasIndex("GorivoId");

                    b.HasIndex("ModelId");

                    b.HasIndex("ParkingSenzorId");

                    b.HasIndex("PogonId");

                    b.HasIndex("TipVozilaId");

                    b.HasIndex("TransmisijaId");

                    b.HasIndex("VrstaKaroserijeId");

                    b.HasIndex("VrstaKlimeId");

                    b.HasIndex("VrstaMotoraId");

                    b.HasIndex("VrstaSvjetlaId");

                    b.ToTable("Vozilo");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.VoziloImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ImageID")
                        .HasColumnType("int");

                    b.Property<int>("VoziloId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImageID");

                    b.HasIndex("VoziloId");

                    b.ToTable("VoziloImage");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.VrstaKaroserije", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VrstaKaroserije");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.VrstaKlime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VrstaKlime");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.VrstaMotora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VrstaMotora");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.VrstaSvjetla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VrstaSvjetla");
                });

            modelBuilder.Entity("Data_AS.EntityModels.VoziloFavorit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KlijentID")
                        .HasColumnType("int");

                    b.Property<int>("KupacId")
                        .HasColumnType("int");

                    b.Property<int>("VoziloId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KlijentID");

                    b.HasIndex("VoziloId");

                    b.ToTable("VoziloFavorit");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Korisnici.Administrator", b =>
                {
                    b.HasOne("Data_AS.EntityModels.Korisnici.Korisnik", "Korisnik")
                        .WithOne("Administrator")
                        .HasForeignKey("Data_AS.EntityModels.Korisnici.Administrator", "KorisnikId");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Korisnici.Klijent", b =>
                {
                    b.HasOne("Data_AS.EntityModels.Korisnici.Korisnik", "Korisnik")
                        .WithOne("Klijent")
                        .HasForeignKey("Data_AS.EntityModels.Korisnici.Klijent", "KorisnikId");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Korisnici.Zaposlenik", b =>
                {
                    b.HasOne("Data_AS.EntityModels.Korisnici.Korisnik", "Korisnik")
                        .WithOne("Zaposlenik")
                        .HasForeignKey("Data_AS.EntityModels.Korisnici.Zaposlenik", "KorisnikId");
                });

            modelBuilder.Entity("Data_AS.EntityModels.Nabavka", b =>
                {
                    b.HasOne("Data_AS.EntityModels.Vozila.Vozilo", "Vozilo")
                        .WithMany()
                        .HasForeignKey("VoziloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Korisnici.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data_AS.EntityModels.Notifikacija", b =>
                {
                    b.HasOne("Data_AS.EntityModels.VoziloFavorit", "VoziloFavorit")
                        .WithMany()
                        .HasForeignKey("VoziloFavoritId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.Vozilo", b =>
                {
                    b.HasOne("Data_AS.EntityModels.Vozila.Boja", "Boja")
                        .WithMany()
                        .HasForeignKey("BojaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.BrojStepeniPrijenosa", "BrojStepeniPrijenosa")
                        .WithMany()
                        .HasForeignKey("BrojStepeniPrijenosaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.BrojVrata", "BrojVrata")
                        .WithMany()
                        .HasForeignKey("BrojVrataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.EmisioniStandard", "EmisioniStandard")
                        .WithMany()
                        .HasForeignKey("EmisioniStandardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.GodinaProizvodnje", "GodinaProizvodnje")
                        .WithMany()
                        .HasForeignKey("GodinaProizvodnjeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.Gorivo", "Gorivo")
                        .WithMany()
                        .HasForeignKey("GorivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.ModelVozila", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");

                    b.HasOne("Data_AS.EntityModels.Vozila.ParkingSenzor", "ParkingSenzor")
                        .WithMany()
                        .HasForeignKey("ParkingSenzorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.Pogon", "Pogon")
                        .WithMany()
                        .HasForeignKey("PogonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.TipVozila", "TipVozila")
                        .WithMany()
                        .HasForeignKey("TipVozilaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.Transmisija", "Transmisija")
                        .WithMany()
                        .HasForeignKey("TransmisijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.VrstaKaroserije", "VrstaKaroserije")
                        .WithMany()
                        .HasForeignKey("VrstaKaroserijeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.VrstaKlime", "VrstaKlime")
                        .WithMany()
                        .HasForeignKey("VrstaKlimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.VrstaMotora", "VrstaMotora")
                        .WithMany()
                        .HasForeignKey("VrstaMotoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.VrstaSvjetla", "VrstaSvjetla")
                        .WithMany()
                        .HasForeignKey("VrstaSvjetlaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data_AS.EntityModels.Vozila.VoziloImage", b =>
                {
                    b.HasOne("Data_AS.EntityModels.Vozila.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Vozila.Vozilo", "Vozilo")
                        .WithMany()
                        .HasForeignKey("VoziloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data_AS.EntityModels.VoziloFavorit", b =>
                {
                    b.HasOne("Data_AS.EntityModels.Korisnici.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentID");

                    b.HasOne("Data_AS.EntityModels.Vozila.Vozilo", "Vozilo")
                        .WithMany()
                        .HasForeignKey("VoziloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Data_AS.EntityModels.Korisnici.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Data_AS.EntityModels.Korisnici.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data_AS.EntityModels.Korisnici.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Data_AS.EntityModels.Korisnici.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
