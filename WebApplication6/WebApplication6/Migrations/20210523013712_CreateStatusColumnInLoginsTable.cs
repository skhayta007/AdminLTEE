using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication6.Migrations
{
    public partial class CreateStatusColumnInLoginsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Logins",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Logins",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Logins");
        }
    }
}
