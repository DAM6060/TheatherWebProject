using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatherWebProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDeleteBehaviourForReal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "868c8914-24a3-41cf-91bd-adb370799cc9", "AQAAAAIAAYagAAAAEPPpII1jNju/odD93Ne7rZbj1LOkvwIKetgYCX79CAZdf0yv/d0uGGtGpTCUWIW1AA==", "f46facef-33a8-4beb-9f86-cde194802883" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10a6eb07-13ff-45c5-b7dc-9ccfdefd96a5", "AQAAAAIAAYagAAAAEOoVL30pACgv5ezfknnS0Kxd/mxdDxQFfUnIYbGMCKFu+Y778hqq3hH2J6Ia+aTtqA==", "da195855-5774-4805-bbca-b32836ad9dfc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44b31f62-7d5a-4d18-a386-9cb47eb0d94d", "AQAAAAIAAYagAAAAEGaxtPY+y6+tJgiEaf9HH3OEYNTN5RO30rSzoA/3voRUsxApzu525do0zhNNvdCDxg==", "3acc226e-edba-4ccc-9850-ad6686a6e7df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18c340af-db76-4e27-b971-4a24d4e96eaa", "AQAAAAIAAYagAAAAEEORQxUUKWBJjwv/KLTw1h4y4DiGvmhsjIPX4osxhkct77HIO7rfZMgr4F7YUHmQSw==", "d486541f-5bc0-4df5-bfd8-864689dfc84e" });
        }
    }
}
