using Microsoft.EntityFrameworkCore.Migrations;

namespace AracIhale.API.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IhaleListesi",
                columns: table => new
                {
                    IhaleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IhaleAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BireyselKurumsalID = table.Column<int>(type: "int", nullable: true),
                    KurumsalSirketAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IhaleStatuID = table.Column<int>(type: "int", nullable: true),
                    IhaleBaslangicTarihi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IhaleBaslangicSaati = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IhaleBitisTarihi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IhaleBitisSaati = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AracID = table.Column<int>(type: "int", nullable: true),
                    IhaleBaslangicFiyati = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MinimumAlimFiyati = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IhaleListesi", x => x.IhaleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IhaleListesi");
        }
    }
}
