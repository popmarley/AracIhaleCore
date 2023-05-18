using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AracIhale.API.Migrations
{
    public partial class ten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BireyselAracTeklif_IhaleListesi_IhaleListesiIhaleID",
                table: "BireyselAracTeklif");

            migrationBuilder.DropForeignKey(
                name: "FK_BireyselAracTeklif_Kullanici_KullaniciID1",
                table: "BireyselAracTeklif");

            migrationBuilder.DropIndex(
                name: "IX_BireyselAracTeklif_IhaleListesiIhaleID",
                table: "BireyselAracTeklif");

            migrationBuilder.DropIndex(
                name: "IX_BireyselAracTeklif_KullaniciID1",
                table: "BireyselAracTeklif");

            migrationBuilder.DropColumn(
                name: "IhaleListesiIhaleID",
                table: "BireyselAracTeklif");

            migrationBuilder.DropColumn(
                name: "KullaniciID1",
                table: "BireyselAracTeklif");

            migrationBuilder.CreateTable(
                name: "OnaylananTeklifs",
                columns: table => new
                {
                    OnaylananTeklifID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeklifID = table.Column<int>(type: "int", nullable: true),
                    KullaniciID = table.Column<int>(type: "int", nullable: true),
                    IhaleID = table.Column<int>(type: "int", nullable: true),
                    OnaylanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BireyselAracTeklifTeklifID = table.Column<int>(type: "int", nullable: true),
                    IhaleListesiIhaleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnaylananTeklifs", x => x.OnaylananTeklifID);
                    table.ForeignKey(
                        name: "FK_OnaylananTeklifs_BireyselAracTeklif_BireyselAracTeklifTeklifID",
                        column: x => x.BireyselAracTeklifTeklifID,
                        principalTable: "BireyselAracTeklif",
                        principalColumn: "TeklifID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnaylananTeklifs_IhaleListesi_IhaleListesiIhaleID",
                        column: x => x.IhaleListesiIhaleID,
                        principalTable: "IhaleListesi",
                        principalColumn: "IhaleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnaylananTeklifs_Kullanici_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OnaylananTeklifs_BireyselAracTeklifTeklifID",
                table: "OnaylananTeklifs",
                column: "BireyselAracTeklifTeklifID");

            migrationBuilder.CreateIndex(
                name: "IX_OnaylananTeklifs_IhaleListesiIhaleID",
                table: "OnaylananTeklifs",
                column: "IhaleListesiIhaleID");

            migrationBuilder.CreateIndex(
                name: "IX_OnaylananTeklifs_KullaniciID",
                table: "OnaylananTeklifs",
                column: "KullaniciID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OnaylananTeklifs");

            migrationBuilder.AddColumn<int>(
                name: "IhaleListesiIhaleID",
                table: "BireyselAracTeklif",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciID1",
                table: "BireyselAracTeklif",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BireyselAracTeklif_IhaleListesiIhaleID",
                table: "BireyselAracTeklif",
                column: "IhaleListesiIhaleID");

            migrationBuilder.CreateIndex(
                name: "IX_BireyselAracTeklif_KullaniciID1",
                table: "BireyselAracTeklif",
                column: "KullaniciID1");

            migrationBuilder.AddForeignKey(
                name: "FK_BireyselAracTeklif_IhaleListesi_IhaleListesiIhaleID",
                table: "BireyselAracTeklif",
                column: "IhaleListesiIhaleID",
                principalTable: "IhaleListesi",
                principalColumn: "IhaleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BireyselAracTeklif_Kullanici_KullaniciID1",
                table: "BireyselAracTeklif",
                column: "KullaniciID1",
                principalTable: "Kullanici",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
