using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatherWebProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedTownVariableToPlay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Town",
                table: "Plays",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Plays",
                keyColumn: "Id",
                keyValue: 1,
                column: "Town",
                value: "Sofia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Town",
                table: "Plays");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e88854af-ed50-473e-9640-ffc7129f283d", "AQAAAAIAAYagAAAAEJMMPlnMqLSWISkpgmiSvplVwrQbY08GcNPdi27z0rbWXBu9KdFFYdtOM8imP0MJvg==", "555935f7-bb39-4ea6-9bde-5e80c4f4fea5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eda3daa-d1f1-4180-814b-26c53f9615a7", "AQAAAAIAAYagAAAAEPkH7gB0+m05F6gIyDoVGDtj1/9X2dzAwoV/m4tLIVmuMxgYrZjr1Xw7Xegr6PW8LQ==", "099015c8-73ff-476c-b981-a1503bdaa1ca" });
        }
    }
}
