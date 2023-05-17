using Microsoft.EntityFrameworkCore.Migrations;

namespace AracIhale.API.Migrations
{
    public partial class eight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IhaleListesi_Araclar_AraclarAracID",
                table: "IhaleListesi");

            migrationBuilder.DropIndex(
                name: "IX_IhaleListesi_AraclarAracID",
                table: "IhaleListesi");

            migrationBuilder.DropColumn(
                name: "AraclarAracID",
                table: "IhaleListesi");

            migrationBuilder.AddColumn<int>(
                name: "KullaniciID1",
                table: "BireyselAracTeklif",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BireyselAracTeklif_IhaleID",
                table: "BireyselAracTeklif",
                column: "IhaleID");

            migrationBuilder.CreateIndex(
                name: "IX_BireyselAracTeklif_KullaniciID1",
                table: "BireyselAracTeklif",
                column: "KullaniciID1");

            migrationBuilder.AddForeignKey(
                name: "FK_BireyselAracTeklif_IhaleListesi_IhaleID",
                table: "BireyselAracTeklif",
                column: "IhaleID",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BireyselAracTeklif_IhaleListesi_IhaleID",
                table: "BireyselAracTeklif");

            migrationBuilder.DropForeignKey(
                name: "FK_BireyselAracTeklif_Kullanici_KullaniciID1",
                table: "BireyselAracTeklif");

            migrationBuilder.DropIndex(
                name: "IX_BireyselAracTeklif_IhaleID",
                table: "BireyselAracTeklif");

            migrationBuilder.DropIndex(
                name: "IX_BireyselAracTeklif_KullaniciID1",
                table: "BireyselAracTeklif");

            migrationBuilder.DropColumn(
                name: "KullaniciID1",
                table: "BireyselAracTeklif");

            migrationBuilder.AddColumn<int>(
                name: "AraclarAracID",
                table: "IhaleListesi",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IhaleListesi_AraclarAracID",
                table: "IhaleListesi",
                column: "AraclarAracID");

            migrationBuilder.AddForeignKey(
                name: "FK_IhaleListesi_Araclar_AraclarAracID",
                table: "IhaleListesi",
                column: "AraclarAracID",
                principalTable: "Araclar",
                principalColumn: "AracID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
