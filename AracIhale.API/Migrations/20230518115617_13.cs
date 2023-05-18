using Microsoft.EntityFrameworkCore.Migrations;

namespace AracIhale.API.Migrations
{
    public partial class _13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OnaylananTeklif_BireyselAracTeklif_TeklifID",
                table: "OnaylananTeklif");

            migrationBuilder.DropIndex(
                name: "IX_OnaylananTeklif_TeklifID",
                table: "OnaylananTeklif");
        }
    }
}
