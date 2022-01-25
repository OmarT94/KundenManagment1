using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KundenManagment1.Server.Migrations
{
    public partial class Kunden : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kunden",
                columns: table => new
                {
                    KdId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KdVorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdStraße = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdHausNummer = table.Column<int>(type: "int", nullable: false),
                    KdStadt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdPLZ = table.Column<int>(type: "int", nullable: false),
                    KdImgPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KdAlter = table.Column<int>(type: "int", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunden", x => x.KdId);
                });

            migrationBuilder.CreateTable(
                name: "Depts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Depts_Kunden_Id",
                        column: x => x.Id,
                        principalTable: "Kunden",
                        principalColumn: "KdId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Depts");

            migrationBuilder.DropTable(
                name: "Kunden");
        }
    }
}
