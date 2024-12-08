using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatherWebProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ActorImageChangedFromSingleImgURLToListImgURLs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActorImageURL",
                table: "Actors",
                newName: "ActorImageURLs");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActorImageURLs",
                table: "Actors",
                newName: "ActorImageURL");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActorImageURL",
                value: "C:\\Users\\ddimi\\source\\repos\\TheatherWebProject\\TheatherWebProject.Infrastructure\\Data\\LocalImageSotrage\\153265986_2893861524220139_5094173891309400300_n.jpg");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "388a489b-3159-4bf9-946a-a2aad6b35320", "AQAAAAIAAYagAAAAEKKWGLWLMlmffBVWF9wpaSNSSZ5v9gg5lbuCc2JrliUmm2I9KiPmxiJ5QC6pSF5yag==", "1c4df79a-7d85-4588-a355-1095b67fed11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "450b74ae-9605-49fc-b053-7e59304405ee", "AQAAAAIAAYagAAAAEPnjse6COBQQgQZRGPfdQmeO4mO3nRAYbOKnmv82yIibD71g9ICxbAMlu/WrRmbp6Q==", "b0301dda-61b6-43cb-a3ce-b913bebfa29d" });
        }
    }
}
