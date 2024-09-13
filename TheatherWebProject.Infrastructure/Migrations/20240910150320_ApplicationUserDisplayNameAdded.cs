﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatherWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationUserDisplayNameAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "ApplicationUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "ApplicationUsers");
        }
    }
}