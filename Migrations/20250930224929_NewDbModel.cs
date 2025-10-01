using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodTracker.Migrations
{
    /// <inheritdoc />
    public partial class NewDbModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarbAmt",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "FatAmt",
                table: "Meals");

            migrationBuilder.RenameColumn(
                name: "ProteinAmt",
                table: "Meals",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FoodName",
                table: "Meals",
                newName: "LoggedAt");

            migrationBuilder.AddColumn<double>(
                name: "Carbs",
                table: "Meals",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Fats",
                table: "Meals",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Protein",
                table: "Meals",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Meals",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Carbs",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Fats",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Protein",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Meals");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Meals",
                newName: "ProteinAmt");

            migrationBuilder.RenameColumn(
                name: "LoggedAt",
                table: "Meals",
                newName: "FoodName");

            migrationBuilder.AddColumn<decimal>(
                name: "CarbAmt",
                table: "Meals",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FatAmt",
                table: "Meals",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
