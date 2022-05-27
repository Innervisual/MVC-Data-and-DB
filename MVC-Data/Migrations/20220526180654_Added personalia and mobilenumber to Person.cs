using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Data.Migrations
{
    public partial class AddedpersonaliaandmobilenumbertoPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "People",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "People",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Personalias",
                columns: table => new
                {
                    SocialSn = table.Column<string>(nullable: false),
                    Length = table.Column<string>(nullable: false),
                    Weight = table.Column<string>(nullable: false),
                    EyeColour = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personalias", x => x.SocialSn);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personalias");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "People");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "People",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
