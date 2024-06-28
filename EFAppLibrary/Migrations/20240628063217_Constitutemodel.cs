using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFAppLibrary.Migrations
{
    public partial class Constitutemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Constitutemodel",
                columns: table => new
                {
                    Constituteid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Constitutename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Totalofconstitute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Totalofmale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Totaloffemale = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constitutemodel", x => x.Constituteid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Constitutemodel");
        }
    }
}
