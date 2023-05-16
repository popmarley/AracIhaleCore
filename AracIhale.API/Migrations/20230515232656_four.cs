using Microsoft.EntityFrameworkCore.Migrations;

namespace AracIhale.API.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rols",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rols", x => x.RolID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_RolID",
                table: "Kullanici",
                column: "RolID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanici_Rols_RolID",
                table: "Kullanici",
                column: "RolID",
                principalTable: "Rols",
                principalColumn: "RolID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanici_Rols_RolID",
                table: "Kullanici");

            migrationBuilder.DropTable(
                name: "Rols");

            migrationBuilder.DropIndex(
                name: "IX_Kullanici_RolID",
                table: "Kullanici");
        }
    }
}
