using Microsoft.EntityFrameworkCore.Migrations;

namespace AracIhale.API.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Araclar_AracOzellik_AracOzellikID",
                table: "Araclar");

            migrationBuilder.DropForeignKey(
                name: "FK_Araclar_BireyselKurumsal_BireyselKurumsalID",
                table: "Araclar");

            migrationBuilder.DropForeignKey(
                name: "FK_Araclar_Kullanici_KullaniciID",
                table: "Araclar");

            migrationBuilder.DropForeignKey(
                name: "FK_IhaleListesi_Araclar_AraclarAracID",
                table: "IhaleListesi");

            migrationBuilder.DropForeignKey(
                name: "FK_IhaleListesi_AracOzellik_AracOzellikID",
                table: "IhaleListesi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AracOzellik",
                table: "AracOzellik");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Araclar",
                table: "Araclar");

            migrationBuilder.RenameTable(
                name: "AracOzellik",
                newName: "AracOzelliks");

            migrationBuilder.RenameTable(
                name: "Araclar",
                newName: "Araclars");

            migrationBuilder.RenameIndex(
                name: "IX_Araclar_KullaniciID",
                table: "Araclars",
                newName: "IX_Araclars_KullaniciID");

            migrationBuilder.RenameIndex(
                name: "IX_Araclar_BireyselKurumsalID",
                table: "Araclars",
                newName: "IX_Araclars_BireyselKurumsalID");

            migrationBuilder.RenameIndex(
                name: "IX_Araclar_AracOzellikID",
                table: "Araclars",
                newName: "IX_Araclars_AracOzellikID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AracOzelliks",
                table: "AracOzelliks",
                column: "AracOzellikID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Araclars",
                table: "Araclars",
                column: "AracID");

            migrationBuilder.AddForeignKey(
                name: "FK_Araclars_AracOzelliks_AracOzellikID",
                table: "Araclars",
                column: "AracOzellikID",
                principalTable: "AracOzelliks",
                principalColumn: "AracOzellikID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Araclars_BireyselKurumsal_BireyselKurumsalID",
                table: "Araclars",
                column: "BireyselKurumsalID",
                principalTable: "BireyselKurumsal",
                principalColumn: "BireselKurumsalID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Araclars_Kullanici_KullaniciID",
                table: "Araclars",
                column: "KullaniciID",
                principalTable: "Kullanici",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IhaleListesi_Araclars_AraclarAracID",
                table: "IhaleListesi",
                column: "AraclarAracID",
                principalTable: "Araclars",
                principalColumn: "AracID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IhaleListesi_AracOzelliks_AracOzellikID",
                table: "IhaleListesi",
                column: "AracOzellikID",
                principalTable: "AracOzelliks",
                principalColumn: "AracOzellikID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Araclars_AracOzelliks_AracOzellikID",
                table: "Araclars");

            migrationBuilder.DropForeignKey(
                name: "FK_Araclars_BireyselKurumsal_BireyselKurumsalID",
                table: "Araclars");

            migrationBuilder.DropForeignKey(
                name: "FK_Araclars_Kullanici_KullaniciID",
                table: "Araclars");

            migrationBuilder.DropForeignKey(
                name: "FK_IhaleListesi_Araclars_AraclarAracID",
                table: "IhaleListesi");

            migrationBuilder.DropForeignKey(
                name: "FK_IhaleListesi_AracOzelliks_AracOzellikID",
                table: "IhaleListesi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AracOzelliks",
                table: "AracOzelliks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Araclars",
                table: "Araclars");

            migrationBuilder.RenameTable(
                name: "AracOzelliks",
                newName: "AracOzellik");

            migrationBuilder.RenameTable(
                name: "Araclars",
                newName: "Araclar");

            migrationBuilder.RenameIndex(
                name: "IX_Araclars_KullaniciID",
                table: "Araclar",
                newName: "IX_Araclar_KullaniciID");

            migrationBuilder.RenameIndex(
                name: "IX_Araclars_BireyselKurumsalID",
                table: "Araclar",
                newName: "IX_Araclar_BireyselKurumsalID");

            migrationBuilder.RenameIndex(
                name: "IX_Araclars_AracOzellikID",
                table: "Araclar",
                newName: "IX_Araclar_AracOzellikID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AracOzellik",
                table: "AracOzellik",
                column: "AracOzellikID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Araclar",
                table: "Araclar",
                column: "AracID");

            migrationBuilder.AddForeignKey(
                name: "FK_Araclar_AracOzellik_AracOzellikID",
                table: "Araclar",
                column: "AracOzellikID",
                principalTable: "AracOzellik",
                principalColumn: "AracOzellikID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Araclar_BireyselKurumsal_BireyselKurumsalID",
                table: "Araclar",
                column: "BireyselKurumsalID",
                principalTable: "BireyselKurumsal",
                principalColumn: "BireselKurumsalID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Araclar_Kullanici_KullaniciID",
                table: "Araclar",
                column: "KullaniciID",
                principalTable: "Kullanici",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);

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
        }
    }
}
