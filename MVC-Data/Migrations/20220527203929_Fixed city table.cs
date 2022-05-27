using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class Fixedcitytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_City_CityId",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "People");

            migrationBuilder.RenameIndex(
                name: "IX_Person_CityId",
                table: "People",
                newName: "IX_People_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_People_City_CityId",
                table: "People",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_City_CityId",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Person");

            migrationBuilder.RenameIndex(
                name: "IX_People_CityId",
                table: "Person",
                newName: "IX_Person_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_City_CityId",
                table: "Person",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
