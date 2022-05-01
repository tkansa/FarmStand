using Microsoft.EntityFrameworkCore.Migrations;

namespace FarmStand.Migrations
{
    public partial class AddedNotedPropToProduce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Produce",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Produce");
        }
    }
}
