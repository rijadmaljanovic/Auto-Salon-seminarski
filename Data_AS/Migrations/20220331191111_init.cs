using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_AS.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrojStepeniPrijenosa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrojStepeniPrijenosa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrojVrata",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrojVrata", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmisioniStandard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmisioniStandard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GodinaProizvodnje",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Godina = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GodinaProizvodnje", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gorivo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorivo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PathToImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModelVozila",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Duzina_m = table.Column<float>(nullable: false),
                    Tezina_t = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelVozila", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkingSenzor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingSenzor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pogon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pogon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipVozila",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipVozila", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmisija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmisija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VrstaKaroserije",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaKaroserije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VrstaKlime",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaKlime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VrstaMotora",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaMotora", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VrstaSvjetla",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaSvjetla", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Administrator_AspNetUsers_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Klijent",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Grad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijent", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Klijent_AspNetUsers_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zaposlenik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresa = table.Column<string>(nullable: true),
                    JMBG = table.Column<string>(nullable: true),
                    DatumZaposlenja = table.Column<DateTime>(nullable: false),
                    KorisnikId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zaposlenik_AspNetUsers_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vozilo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cijena = table.Column<float>(nullable: true),
                    RegistrovanDo = table.Column<DateTime>(nullable: true),
                    PredjeniKilometri = table.Column<float>(nullable: true),
                    SnagaMotoraKW = table.Column<float>(nullable: true),
                    SnagaMotoraKS = table.Column<int>(nullable: true),
                    Kubikaza = table.Column<float>(nullable: true),
                    Marka = table.Column<string>(nullable: true),
                    ModelId = table.Column<int>(nullable: true),
                    BrojStepeniPrijenosaId = table.Column<int>(nullable: false),
                    GorivoId = table.Column<int>(nullable: false),
                    TransmisijaId = table.Column<int>(nullable: false),
                    GodinaProizvodnjeId = table.Column<int>(nullable: false),
                    ParkingSenzorId = table.Column<int>(nullable: false),
                    VrstaMotoraId = table.Column<int>(nullable: false),
                    VrstaKlimeId = table.Column<int>(nullable: false),
                    TipVozilaId = table.Column<int>(nullable: false),
                    BojaId = table.Column<int>(nullable: false),
                    BrojVrataId = table.Column<int>(nullable: false),
                    PogonId = table.Column<int>(nullable: false),
                    EmisioniStandardId = table.Column<int>(nullable: false),
                    VrstaSvjetlaId = table.Column<int>(nullable: false),
                    VrstaKaroserijeId = table.Column<int>(nullable: false),
                    ABS = table.Column<bool>(nullable: false),
                    Alarm = table.Column<bool>(nullable: false),
                    ESP = table.Column<bool>(nullable: false),
                    Bluetooth = table.Column<bool>(nullable: false),
                    Maglenke = table.Column<bool>(nullable: false),
                    Metalik = table.Column<bool>(nullable: false),
                    Mat = table.Column<bool>(nullable: false),
                    Tempomat = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozilo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vozilo_Boja_BojaId",
                        column: x => x.BojaId,
                        principalTable: "Boja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_BrojStepeniPrijenosa_BrojStepeniPrijenosaId",
                        column: x => x.BrojStepeniPrijenosaId,
                        principalTable: "BrojStepeniPrijenosa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_BrojVrata_BrojVrataId",
                        column: x => x.BrojVrataId,
                        principalTable: "BrojVrata",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_EmisioniStandard_EmisioniStandardId",
                        column: x => x.EmisioniStandardId,
                        principalTable: "EmisioniStandard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_GodinaProizvodnje_GodinaProizvodnjeId",
                        column: x => x.GodinaProizvodnjeId,
                        principalTable: "GodinaProizvodnje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_Gorivo_GorivoId",
                        column: x => x.GorivoId,
                        principalTable: "Gorivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_ModelVozila_ModelId",
                        column: x => x.ModelId,
                        principalTable: "ModelVozila",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vozilo_ParkingSenzor_ParkingSenzorId",
                        column: x => x.ParkingSenzorId,
                        principalTable: "ParkingSenzor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_Pogon_PogonId",
                        column: x => x.PogonId,
                        principalTable: "Pogon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_TipVozila_TipVozilaId",
                        column: x => x.TipVozilaId,
                        principalTable: "TipVozila",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_Transmisija_TransmisijaId",
                        column: x => x.TransmisijaId,
                        principalTable: "Transmisija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_VrstaKaroserije_VrstaKaroserijeId",
                        column: x => x.VrstaKaroserijeId,
                        principalTable: "VrstaKaroserije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_VrstaKlime_VrstaKlimeId",
                        column: x => x.VrstaKlimeId,
                        principalTable: "VrstaKlime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_VrstaMotora_VrstaMotoraId",
                        column: x => x.VrstaMotoraId,
                        principalTable: "VrstaMotora",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vozilo_VrstaSvjetla_VrstaSvjetlaId",
                        column: x => x.VrstaSvjetlaId,
                        principalTable: "VrstaSvjetla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nabavka",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoziloId = table.Column<int>(nullable: false),
                    ZaposlenikId = table.Column<int>(nullable: false),
                    DatumNabavke = table.Column<DateTime>(nullable: false),
                    Cijena = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nabavka", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nabavka_Vozilo_VoziloId",
                        column: x => x.VoziloId,
                        principalTable: "Vozilo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nabavka_Zaposlenik_ZaposlenikId",
                        column: x => x.ZaposlenikId,
                        principalTable: "Zaposlenik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoziloFavorit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KupacId = table.Column<int>(nullable: false),
                    KlijentID = table.Column<int>(nullable: true),
                    VoziloId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoziloFavorit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoziloFavorit_Klijent_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VoziloFavorit_Vozilo_VoziloId",
                        column: x => x.VoziloId,
                        principalTable: "Vozilo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoziloImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoziloId = table.Column<int>(nullable: false),
                    ImageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoziloImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoziloImage_Image_ImageID",
                        column: x => x.ImageID,
                        principalTable: "Image",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VoziloImage_Vozilo_VoziloId",
                        column: x => x.VoziloId,
                        principalTable: "Vozilo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifikacija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoziloFavoritId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Vidjeno = table.Column<bool>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifikacija_VoziloFavorit_VoziloFavoritId",
                        column: x => x.VoziloFavoritId,
                        principalTable: "VoziloFavorit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_KorisnikId",
                table: "Administrator",
                column: "KorisnikId",
                unique: true,
                filter: "[KorisnikId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Klijent_KorisnikId",
                table: "Klijent",
                column: "KorisnikId",
                unique: true,
                filter: "[KorisnikId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Nabavka_VoziloId",
                table: "Nabavka",
                column: "VoziloId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nabavka_ZaposlenikId",
                table: "Nabavka",
                column: "ZaposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacija_VoziloFavoritId",
                table: "Notifikacija",
                column: "VoziloFavoritId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_BojaId",
                table: "Vozilo",
                column: "BojaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_BrojStepeniPrijenosaId",
                table: "Vozilo",
                column: "BrojStepeniPrijenosaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_BrojVrataId",
                table: "Vozilo",
                column: "BrojVrataId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_EmisioniStandardId",
                table: "Vozilo",
                column: "EmisioniStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_GodinaProizvodnjeId",
                table: "Vozilo",
                column: "GodinaProizvodnjeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_GorivoId",
                table: "Vozilo",
                column: "GorivoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_ModelId",
                table: "Vozilo",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_ParkingSenzorId",
                table: "Vozilo",
                column: "ParkingSenzorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_PogonId",
                table: "Vozilo",
                column: "PogonId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_TipVozilaId",
                table: "Vozilo",
                column: "TipVozilaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_TransmisijaId",
                table: "Vozilo",
                column: "TransmisijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_VrstaKaroserijeId",
                table: "Vozilo",
                column: "VrstaKaroserijeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_VrstaKlimeId",
                table: "Vozilo",
                column: "VrstaKlimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_VrstaMotoraId",
                table: "Vozilo",
                column: "VrstaMotoraId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_VrstaSvjetlaId",
                table: "Vozilo",
                column: "VrstaSvjetlaId");

            migrationBuilder.CreateIndex(
                name: "IX_VoziloFavorit_KlijentID",
                table: "VoziloFavorit",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_VoziloFavorit_VoziloId",
                table: "VoziloFavorit",
                column: "VoziloId");

            migrationBuilder.CreateIndex(
                name: "IX_VoziloImage_ImageID",
                table: "VoziloImage",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_VoziloImage_VoziloId",
                table: "VoziloImage",
                column: "VoziloId");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenik_KorisnikId",
                table: "Zaposlenik",
                column: "KorisnikId",
                unique: true,
                filter: "[KorisnikId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Nabavka");

            migrationBuilder.DropTable(
                name: "Notifikacija");

            migrationBuilder.DropTable(
                name: "VoziloImage");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Zaposlenik");

            migrationBuilder.DropTable(
                name: "VoziloFavorit");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Klijent");

            migrationBuilder.DropTable(
                name: "Vozilo");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Boja");

            migrationBuilder.DropTable(
                name: "BrojStepeniPrijenosa");

            migrationBuilder.DropTable(
                name: "BrojVrata");

            migrationBuilder.DropTable(
                name: "EmisioniStandard");

            migrationBuilder.DropTable(
                name: "GodinaProizvodnje");

            migrationBuilder.DropTable(
                name: "Gorivo");

            migrationBuilder.DropTable(
                name: "ModelVozila");

            migrationBuilder.DropTable(
                name: "ParkingSenzor");

            migrationBuilder.DropTable(
                name: "Pogon");

            migrationBuilder.DropTable(
                name: "TipVozila");

            migrationBuilder.DropTable(
                name: "Transmisija");

            migrationBuilder.DropTable(
                name: "VrstaKaroserije");

            migrationBuilder.DropTable(
                name: "VrstaKlime");

            migrationBuilder.DropTable(
                name: "VrstaMotora");

            migrationBuilder.DropTable(
                name: "VrstaSvjetla");
        }
    }
}
