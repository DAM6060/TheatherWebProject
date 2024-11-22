using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatherWebProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class newLaptop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e636e5c5-f452-4a3e-a996-311e5f7aa2e1", "AQAAAAIAAYagAAAAEIJFBM40Wc9Iw1TiRxUSoowHCN1yDsMNetv3dnzheOoScKXodFTUMxus/jxMF+851w==", "0039cc68-3f8d-4a24-b35c-58d3ad14223f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f862996f-63d7-47f0-8b92-c854f61ad5c7", "AQAAAAIAAYagAAAAEKi+N8ekJVKVEbYiESFJH59d4MfRG/TM4f33MjFvpzIBQ8uwFq4HG7cm7o32GhI4OQ==", "cf60fee4-7db7-4eb6-ac91-60f35881ce45" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0947495d-a5b3-4c70-bb90-e8a5eb102395", "AQAAAAIAAYagAAAAEP67U+BtowaIbVCzaOCp4wvyrbVFwmV+dDSg1tnJWEEE1xqu3tiSJ9c8evm9uToTuA==", "81d4394f-5259-4d2f-b834-370ca0c62ad3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4743d51a-b6a2-4cee-a5dc-0a3f67c761b6", "AQAAAAIAAYagAAAAECr1A+I5Q3A+5lAJJXUaBkLLQzcbJv+pikJHLt98fK4O9vR4y/j/rIXrBIe9ZRHdAg==", "0a9bb105-5377-43c2-8b82-f62b3608e41d" });
        }
    }
}
