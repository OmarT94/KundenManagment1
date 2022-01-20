using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KundenManagment1.Server.Migrations
{
    public partial class Dept : Migration
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

            migrationBuilder.CreateTable(
                name: "Depts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KundeKdId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Depts_Kunden_KundeKdId",
                        column: x => x.KundeKdId,
                        principalTable: "Kunden",
                        principalColumn: "KdId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Depts_KundeKdId",
                table: "Depts",
                column: "KundeKdId");
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
