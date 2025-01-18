using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_Manager.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedByToJokes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Joke");
        }
    }
}
