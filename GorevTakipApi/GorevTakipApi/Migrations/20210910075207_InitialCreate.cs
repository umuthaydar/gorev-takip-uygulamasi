using Microsoft.EntityFrameworkCore.Migrations;

namespace GorevTakipApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GorevTakipDetays",
                columns: table => new
                {
                    RecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nchar(10)", nullable: true),
                    GorevBasligi = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Görev = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    KayitTarihi = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    TerminTarihi = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    YapilmaTarihi = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevTakipDetays", x => x.RecId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GorevTakipDetays");
        }
    }
}
