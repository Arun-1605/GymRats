using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gymrats.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addednewfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NoOfMonths",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoOfMonths",
                table: "Users");
        }
    }
}
