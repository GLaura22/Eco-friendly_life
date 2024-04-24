using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eco_friendly_life_winform.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_673 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CarbonFootprint",
                table: "Ingredients",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarbonFootprint",
                table: "Ingredients");
        }
    }
}
