using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eco_friendly_life_winform.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_243 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Comments",
                newName: "MealID");

            migrationBuilder.AddColumn<byte[]>(
                name: "MealImage",
                table: "Comments",
                type: "image",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MealImage",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "MealID",
                table: "Comments",
                newName: "Content");
        }
    }
}
