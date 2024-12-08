using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatherWebProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedImgageLocationToWWWRoot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActorImageURLs",
                value: "[\"C:\\\\Users\\\\ddimi\\\\source\\\\repos\\\\TheatherWebProject\\\\TheatherWebProject\\\\bin\\\\Debug\\\\net8.0\\\\LocalImageStorage\\\\153265986_2893861524220139_5094173891309400300_n.jpg\"]");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51e4a012-eef1-40b7-94f0-427f1a2b67a2", "AQAAAAIAAYagAAAAEDQT7V3Jybdl4B5Tkr4Gh/DXmU9uNNfHNEBg/YyydC8Wb/z3IHGupYNNH4aHicRwTw==", "fa984be4-ff77-402c-9002-164b3771742a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91eebe61-a168-4519-a081-078cbf4b3f57", "AQAAAAIAAYagAAAAEN6zVXZSYqinEmbMpsJMMO5NgvPWs5xkksLrMZTHVD2XNphzIatSXFZHRFCaiZsMUA==", "fb824824-be28-4611-b943-7f627e1cd45c" });

            migrationBuilder.UpdateData(
                table: "Plays",
                keyColumn: "Id",
                keyValue: 1,
                column: "PlayImagesURLs",
                value: "[\"C:\\\\Users\\\\ddimi\\\\source\\\\repos\\\\TheatherWebProject\\\\TheatherWebProject.Infrastructure\\\\Data\\\\LocalImageSotrage\\\\IMG_0843(i).jpg\",\"C:\\\\Users\\\\ddimi\\\\source\\\\repos\\\\TheatherWebProject\\\\TheatherWebProject.Infrastructure\\\\Data\\\\LocalImageSotrage\\\\dyslexia card.jpg\"]");
        }
    }
}
