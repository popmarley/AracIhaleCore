using Microsoft.EntityFrameworkCore.Migrations;

namespace AracIhale.API.Migrations
{
    public partial class eleven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OnaylananTeklifs_BireyselAracTeklif_BireyselAracTeklifTeklifID",
                table: "OnaylananTeklifs");

            migrationBuilder.DropForeignKey(
                name: "FK_OnaylananTeklifs_IhaleListesi_IhaleListesiIhaleID",
                table: "OnaylananTeklifs");

            migrationBuilder.DropForeignKey(
                name: "FK_OnaylananTeklifs_Kullanici_KullaniciID",
                table: "OnaylananTeklifs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OnaylananTeklifs",
                table: "OnaylananTeklifs");

            migrationBuilder.DropIndex(
                name: "IX_OnaylananTeklifs_BireyselAracTeklifTeklifID",
                table: "OnaylananTeklifs");

            migrationBuilder.DropIndex(
                name: "IX_OnaylananTeklifs_IhaleListesiIhaleID",
                table: "OnaylananTeklifs");

            migrationBuilder.DropColumn(
                name: "BireyselAracTeklifTeklifID",
                table: "OnaylananTeklifs");

            migrationBuilder.DropColumn(
                name: "IhaleListesiIhaleID",
                table: "OnaylananTeklifs");

            migrationBuilder.RenameTable(
                name: "OnaylananTeklifs",
                newName: "OnaylananTeklif");

            migrationBuilder.RenameIndex(
                name: "IX_OnaylananTeklifs_KullaniciID",
                table: "OnaylananTeklif",
                newName: "IX_OnaylananTeklif_KullaniciID");

            migrationBuilder.AddColumn<string>(
                name: "TeklifFiyati",
                table: "OnaylananTeklif",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OnaylananTeklif",
                table: "OnaylananTeklif",
                column: "OnaylananTeklifID");

            migrationBuilder.CreateIndex(
                name: "IX_OnaylananTeklif_IhaleID",
                table: "OnaylananTeklif",
                column: "IhaleID");

            migrationBuilder.CreateIndex(
                name: "IX_OnaylananTeklif_TeklifID",
                table: "OnaylananTeklif",
                column: "TeklifID");

            migrationBuilder.AddForeignKey(
                name: "FK_OnaylananTeklif_BireyselAracTeklif_TeklifID",
                table: "OnaylananTeklif",
                column: "TeklifID",
                principalTable: "BireyselAracTeklif",
                principalColumn: "TeklifID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OnaylananTeklif_IhaleListesi_IhaleID",
                table: "OnaylananTeklif",
                column: "IhaleID",
                principalTable: "IhaleListesi",
                principalColumn: "IhaleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OnaylananTeklif_Kullanici_KullaniciID",
                table: "OnaylananTeklif",
                column: "KullaniciID",
                principalTable: "Kullanici",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OnaylananTeklif_BireyselAracTeklif_TeklifID",
                table: "OnaylananTeklif");

            migrationBuilder.DropForeignKey(
                name: "FK_OnaylananTeklif_IhaleListesi_IhaleID",
                table: "OnaylananTeklif");

            migrationBuilder.DropForeignKey(
                name: "FK_OnaylananTeklif_Kullanici_KullaniciID",
                table: "OnaylananTeklif");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OnaylananTeklif",
                table: "OnaylananTeklif");

            migrationBuilder.DropIndex(
                name: "IX_OnaylananTeklif_IhaleID",
                table: "OnaylananTeklif");

            migrationBuilder.DropIndex(
                name: "IX_OnaylananTeklif_TeklifID",
                table: "OnaylananTeklif");

            migrationBuilder.DropColumn(
                name: "TeklifFiyati",
                table: "OnaylananTeklif");

            migrationBuilder.RenameTable(
                name: "OnaylananTeklif",
                newName: "OnaylananTeklifs");

            migrationBuilder.RenameIndex(
                name: "IX_OnaylananTeklif_KullaniciID",
                table: "OnaylananTeklifs",
                newName: "IX_OnaylananTeklifs_KullaniciID");

            migrationBuilder.AddColumn<int>(
                name: "BireyselAracTeklifTeklifID",
                table: "OnaylananTeklifs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IhaleListesiIhaleID",
                table: "OnaylananTeklifs",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OnaylananTeklifs",
                table: "OnaylananTeklifs",
                column: "OnaylananTeklifID");

            migrationBuilder.CreateIndex(
                name: "IX_OnaylananTeklifs_BireyselAracTeklifTeklifID",
                table: "OnaylananTeklifs",
                column: "BireyselAracTeklifTeklifID");

            migrationBuilder.CreateIndex(
                name: "IX_OnaylananTeklifs_IhaleListesiIhaleID",
                table: "OnaylananTeklifs",
                column: "IhaleListesiIhaleID");

            migrationBuilder.AddForeignKey(
                name: "FK_OnaylananTeklifs_BireyselAracTeklif_BireyselAracTeklifTeklifID",
                table: "OnaylananTeklifs",
                column: "BireyselAracTeklifTeklifID",
                principalTable: "BireyselAracTeklif",
                principalColumn: "TeklifID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OnaylananTeklifs_IhaleListesi_IhaleListesiIhaleID",
                table: "OnaylananTeklifs",
                column: "IhaleListesiIhaleID",
                principalTable: "IhaleListesi",
                principalColumn: "IhaleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OnaylananTeklifs_Kullanici_KullaniciID",
                table: "OnaylananTeklifs",
                column: "KullaniciID",
                principalTable: "Kullanici",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
