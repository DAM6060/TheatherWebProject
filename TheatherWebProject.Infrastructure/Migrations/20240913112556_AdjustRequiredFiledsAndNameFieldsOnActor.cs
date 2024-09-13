using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatherWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdjustRequiredFiledsAndNameFieldsOnActor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameLast",
                table: "Actors",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "NameFirst",
                table: "Actors",
                newName: "FirstName");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Plays",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Plays");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Actors",
                newName: "NameLast");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Actors",
                newName: "NameFirst");
        }
    }
}
