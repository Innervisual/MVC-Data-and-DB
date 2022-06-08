using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class Addedcities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Person",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_CityId",
                table: "Person",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_City_CityId",
                table: "Person",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_City_CityId",
                table: "Person");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropIndex(
                name: "IX_Person_CityId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Person");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
