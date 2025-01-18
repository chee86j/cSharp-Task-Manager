using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_Manager.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryToTaskItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Joke");
        }
    }
}
