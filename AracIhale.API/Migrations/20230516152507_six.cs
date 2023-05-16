using Microsoft.EntityFrameworkCore.Migrations;

namespace AracIhale.API.Migrations
{
    public partial class six : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AracMarkas",
                columns: table => new
                {
                    MarkaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkaAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracMarkas", x => x.MarkaID);
                });

            migrationBuilder.CreateTable(
                name: "AracModels",
                columns: table => new
                {
                    AracModelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AracMarkaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AracModels", x => x.AracModelID);
                    table.ForeignKey(
                        name: "FK_AracModels_AracMarkas_AracMarkaID",
                        column: x => x.AracMarkaID,
                        principalTable: "AracMarkas",
                        principalColumn: "MarkaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AracOzellik_AracMarkaID",
                table: "AracOzellik",
                column: "AracMarkaID");

            migrationBuilder.CreateIndex(
                name: "IX_AracOzellik_AracModelID",
                table: "AracOzellik",
                column: "AracModelID");

            migrationBuilder.CreateIndex(
                name: "IX_AracModels_AracMarkaID",
                table: "AracModels",
                column: "AracMarkaID");

            migrationBuilder.AddForeignKey(
                name: "FK_AracOzellik_AracMarkas_AracMarkaID",
                table: "AracOzellik",
                column: "AracMarkaID",
                principalTable: "AracMarkas",
                principalColumn: "MarkaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AracOzellik_AracModels_AracModelID",
                table: "AracOzellik",
                column: "AracModelID",
                principalTable: "AracModels",
                principalColumn: "AracModelID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AracOzellik_AracMarkas_AracMarkaID",
                table: "AracOzellik");

            migrationBuilder.DropForeignKey(
                name: "FK_AracOzellik_AracModels_AracModelID",
                table: "AracOzellik");

            migrationBuilder.DropTable(
                name: "AracModels");

            migrationBuilder.DropTable(
                name: "AracMarkas");

            migrationBuilder.DropIndex(
                name: "IX_AracOzellik_AracMarkaID",
                table: "AracOzellik");

            migrationBuilder.DropIndex(
                name: "IX_AracOzellik_AracModelID",
                table: "AracOzellik");
        }
    }
}
