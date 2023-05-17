using Microsoft.EntityFrameworkCore.Migrations;

namespace AracIhale.API.Migrations
{
    public partial class seven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_IhaleListesi_AracID",
                table: "IhaleListesi",
                column: "AracID");

            migrationBuilder.AddForeignKey(
                name: "FK_IhaleListesi_Araclar_AracID",
                table: "IhaleListesi",
                column: "AracID",
                principalTable: "Araclar",
                principalColumn: "AracID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IhaleListesi_Araclar_AracID",
                table: "IhaleListesi");

            migrationBuilder.DropIndex(
                name: "IX_IhaleListesi_AracID",
                table: "IhaleListesi");
        }
    }
}
