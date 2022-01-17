using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KundenManagment1.Server.Migrations
{
    public partial class MYMIGRATION : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kunden",
                columns: table => new
                {
                    KdId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdAdresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdImgPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdAlter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunden", x => x.KdId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kunden");
        }
    }
}
