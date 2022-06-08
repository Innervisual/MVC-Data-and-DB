using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class RemovedMobilNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "People");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
