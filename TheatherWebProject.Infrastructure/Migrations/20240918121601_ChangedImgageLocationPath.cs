using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatherWebProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedImgageLocationPath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActorImageURLs",
                value: "[\"/Images/153265986_2893861524220139_5094173891309400300_n.jpg\"]");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c79181f-c700-4fe9-83d5-db4d900499ff", "AQAAAAIAAYagAAAAECwfkN/jt8OYPgTHAFqFIdSOqtPyQdbH7NlNJYofTET8l0U9wnbGkQzRyG9Pe0faPQ==", "f3b0b6b2-d341-481c-93d3-02adee98edfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df8ff410-e9e9-4622-9d39-891d5c8c7117", "AQAAAAIAAYagAAAAEF92xYfblAoLrv6c5XhptZuFYDWEYZpov1pCogBxdNo23Di/rrscgBOECHvmv4uttQ==", "83eab811-c489-4e58-aba4-dc3fc0443f94" });

            migrationBuilder.UpdateData(
                table: "Plays",
                keyColumn: "Id",
                keyValue: 1,
                column: "PlayImagesURLs",
                value: "[\"/Images/IMG_0843(i).jpg\",\"/Images/dyslexia card.jpg\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActorImageURLs",
                value: "[\"\\\\wwwroot\\\\Images\\\\153265986_2893861524220139_5094173891309400300_n.jpg\"]");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2f78f56-7fa1-430f-8815-14d28ba3bec6", "AQAAAAIAAYagAAAAEAZNRHw8+fAmFuvkx++cvTGN0RLUn26u/l4u5uGFwrkAfCkyTixLuNii7UW5la8vCQ==", "ed59c860-5b97-4f0a-802b-ebc3ee14cacd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eadd6af-4eab-4735-944b-c04ffef096c8", "AQAAAAIAAYagAAAAEFcjORMMV2pqkQhOVaWBAGaMZlV5n3LW/+z4bp+LCc7vzLogjvY+lymfPz5YDDoUXw==", "576c9242-25da-4932-a8a6-9f82e784afd7" });

            migrationBuilder.UpdateData(
                table: "Plays",
                keyColumn: "Id",
                keyValue: 1,
                column: "PlayImagesURLs",
                value: "[\"\\\\wwwroot\\\\Images\\\\\\\\IMG_0843(i).jpg\",\"\\\\wwwroot\\\\Images\\\\dyslexia card.jpg\"]");
        }
    }
}
