using Microsoft.EntityFrameworkCore.Migrations;

namespace identitytest.Data.Migrations
{
    public partial class testcustom01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomProp",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomProp",
                table: "AspNetUsers");
        }
    }
}
