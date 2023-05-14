using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AracIhale.API.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AracOzellikID",
                table: "IhaleListesi",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AraclarAracID",
                table: "IhaleListesi",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AracOzellik",
                columns: table => new
                {
                    AracOzellikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AracMarkaID = table.Column<int>(type: "int", nullable: true),
                    YilID = table.Column<int>(type: "int", nullable: true),
                    AracModelID = table.Column<int>(type: "int", nullable: true),
                    GovdeTipiID = table.Column<int>(type: "int", nullable: true),
                    YakitTipiID = table.Column<int>(type: "int", nullable: true),
                    VitesTipiID = table.Column<int>(type: "int", nullable: true),
                    Versiyon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RenkID = table.Column<int>(type: "int", nullable: true),
                    OpsiyonelDonanim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracOzellik", x => x.AracOzellikID);
                });

            migrationBuilder.CreateTable(
                name: "BireyselKurumsal",
                columns: table => new
                {
                    BireselKurumsalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BireyselKurumsal", x => x.BireselKurumsalID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AktifPasifID = table.Column<int>(type: "int", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RolID = table.Column<int>(type: "int", nullable: true),
                    Fotograf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KurumsalIl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KurumsalIlce = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KurumsalAdres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FirmaAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirmaBilgisiID = table.Column<int>(type: "int", nullable: true),
                    BireyselKurumsalID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.KullaniciID);
                    table.ForeignKey(
                        name: "FK_Kullanici_BireyselKurumsal_BireyselKurumsalID",
                        column: x => x.BireyselKurumsalID,
                        principalTable: "BireyselKurumsal",
                        principalColumn: "BireselKurumsalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Araclar",
                columns: table => new
                {
                    AracID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BireyselKurumsalID = table.Column<int>(type: "int", nullable: true),
                    KurumsalSirketAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StatuID = table.Column<int>(type: "int", nullable: true),
                    AracFiyati = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AracOzellikID = table.Column<int>(type: "int", nullable: true),
                    KMBilgisi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Donanim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gorsel1 = table.Column<byte[]>(type: "varbinary(50)", maxLength: 50, nullable: true),
                    Gorsel2 = table.Column<byte[]>(type: "varbinary(50)", maxLength: 50, nullable: true),
                    Gorsel3 = table.Column<byte[]>(type: "varbinary(50)", maxLength: 50, nullable: true),
                    Gorsel4 = table.Column<byte[]>(type: "varbinary(50)", maxLength: 50, nullable: true),
                    Gorsel5 = table.Column<byte[]>(type: "varbinary(50)", maxLength: 50, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciID = table.Column<int>(type: "int", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Plaka = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Araclar", x => x.AracID);
                    table.ForeignKey(
                        name: "FK_Araclar_AracOzellik_AracOzellikID",
                        column: x => x.AracOzellikID,
                        principalTable: "AracOzellik",
                        principalColumn: "AracOzellikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Araclar_BireyselKurumsal_BireyselKurumsalID",
                        column: x => x.BireyselKurumsalID,
                        principalTable: "BireyselKurumsal",
                        principalColumn: "BireselKurumsalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Araclar_Kullanici_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IhaleListesi_AraclarAracID",
                table: "IhaleListesi",
                column: "AraclarAracID");

            migrationBuilder.CreateIndex(
                name: "IX_IhaleListesi_AracOzellikID",
                table: "IhaleListesi",
                column: "AracOzellikID");

            migrationBuilder.CreateIndex(
                name: "IX_IhaleListesi_BireyselKurumsalID",
                table: "IhaleListesi",
                column: "BireyselKurumsalID");

            migrationBuilder.CreateIndex(
                name: "IX_Araclar_AracOzellikID",
                table: "Araclar",
                column: "AracOzellikID");

            migrationBuilder.CreateIndex(
                name: "IX_Araclar_BireyselKurumsalID",
                table: "Araclar",
                column: "BireyselKurumsalID");

            migrationBuilder.CreateIndex(
                name: "IX_Araclar_KullaniciID",
                table: "Araclar",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_BireyselKurumsalID",
                table: "Kullanici",
                column: "BireyselKurumsalID");

            migrationBuilder.AddForeignKey(
                name: "FK_IhaleListesi_Araclar_AraclarAracID",
                table: "IhaleListesi",
                column: "AraclarAracID",
                principalTable: "Araclar",
                principalColumn: "AracID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IhaleListesi_AracOzellik_AracOzellikID",
                table: "IhaleListesi",
                column: "AracOzellikID",
                principalTable: "AracOzellik",
                principalColumn: "AracOzellikID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IhaleListesi_BireyselKurumsal_BireyselKurumsalID",
                table: "IhaleListesi",
                column: "BireyselKurumsalID",
                principalTable: "BireyselKurumsal",
                principalColumn: "BireselKurumsalID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IhaleListesi_Araclar_AraclarAracID",
                table: "IhaleListesi");

            migrationBuilder.DropForeignKey(
                name: "FK_IhaleListesi_AracOzellik_AracOzellikID",
                table: "IhaleListesi");

            migrationBuilder.DropForeignKey(
                name: "FK_IhaleListesi_BireyselKurumsal_BireyselKurumsalID",
                table: "IhaleListesi");

            migrationBuilder.DropTable(
                name: "Araclar");

            migrationBuilder.DropTable(
                name: "AracOzellik");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "BireyselKurumsal");

            migrationBuilder.DropIndex(
                name: "IX_IhaleListesi_AraclarAracID",
                table: "IhaleListesi");

            migrationBuilder.DropIndex(
                name: "IX_IhaleListesi_AracOzellikID",
                table: "IhaleListesi");

            migrationBuilder.DropIndex(
                name: "IX_IhaleListesi_BireyselKurumsalID",
                table: "IhaleListesi");

            migrationBuilder.DropColumn(
                name: "AracOzellikID",
                table: "IhaleListesi");

            migrationBuilder.DropColumn(
                name: "AraclarAracID",
                table: "IhaleListesi");
        }
    }
}
