using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheatherWebProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayImagesURLs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayVideosURLs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TicketURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorsPlays",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    PlayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorsPlays", x => new { x.ActorId, x.PlayId });
                    table.ForeignKey(
                        name: "FK_ActorsPlays_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorsPlays_Plays_PlayId",
                        column: x => x.PlayId,
                        principalTable: "Plays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserFavouritePlays",
                columns: table => new
                {
                    ApplicationUsersFavouritePlaysId = table.Column<int>(type: "int", nullable: false),
                    FavouritePlaysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserFavouritePlays", x => new { x.ApplicationUsersFavouritePlaysId, x.FavouritePlaysId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserFavouritePlays_ApplicationUsers_ApplicationUsersFavouritePlaysId",
                        column: x => x.ApplicationUsersFavouritePlaysId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserFavouritePlays_Plays_FavouritePlaysId",
                        column: x => x.FavouritePlaysId,
                        principalTable: "Plays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserGoingToPlays",
                columns: table => new
                {
                    ApplicationUsersGoingToPlaysId = table.Column<int>(type: "int", nullable: false),
                    GoingToPlaysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserGoingToPlays", x => new { x.ApplicationUsersGoingToPlaysId, x.GoingToPlaysId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserGoingToPlays_ApplicationUsers_ApplicationUsersGoingToPlaysId",
                        column: x => x.ApplicationUsersGoingToPlaysId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserGoingToPlays_Plays_GoingToPlaysId",
                        column: x => x.GoingToPlaysId,
                        principalTable: "Plays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserLikedPlays",
                columns: table => new
                {
                    ApplicationUsersLikedPlaysId = table.Column<int>(type: "int", nullable: false),
                    LikedPlaysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserLikedPlays", x => new { x.ApplicationUsersLikedPlaysId, x.LikedPlaysId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserLikedPlays_ApplicationUsers_ApplicationUsersLikedPlaysId",
                        column: x => x.ApplicationUsersLikedPlaysId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserLikedPlays_Plays_LikedPlaysId",
                        column: x => x.LikedPlaysId,
                        principalTable: "Plays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserWatchedPlays",
                columns: table => new
                {
                    ApplicationUsersWatchedPlaysId = table.Column<int>(type: "int", nullable: false),
                    WatchedPlaysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserWatchedPlays", x => new { x.ApplicationUsersWatchedPlaysId, x.WatchedPlaysId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserWatchedPlays_ApplicationUsers_ApplicationUsersWatchedPlaysId",
                        column: x => x.ApplicationUsersWatchedPlaysId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserWatchedPlays_Plays_WatchedPlaysId",
                        column: x => x.WatchedPlaysId,
                        principalTable: "Plays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlayId = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_ApplicationUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Plays_PlayId",
                        column: x => x.PlayId,
                        principalTable: "Plays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageURL", "Description", "FirstName", "LastName" },
                values: new object[] { 1, "C:\\Users\\ddimi\\source\\repos\\TheatherWebProject\\TheatherWebProject.Infrastructure\\Data\\LocalImageSotrage\\153265986_2893861524220139_5094173891309400300_n.jpg", "Alex Dimitrova is a young and talented actor who has been in the industry for 5 years. She has starred in a number of successful films and TV shows and has received critical acclaim for her performances. She is known for her versatility and ability to bring depth and emotion to her characters. Alex is a dedicated and hard-working actor who is always looking to challenge herself and push the boundaries of her craft. She is passionate about her work and is committed to delivering the best possible performance in every role she takes on.", "Alex", "Dimitrova" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "6549b8af-08dd-4f0d-8dc9-0fced5c94fe9", "varnasharks.afc@gmail.com", false, false, null, "VARNASHARKS.AFC@GMAIL.COM", "VARNASHARKS.AFC@GMAIL.COM", "AQAAAAIAAYagAAAAEFyOMgPp153rvaoGhzyjNnpUxscTyV+D575vZ58OD8IB3MLAz6bF+0sq/TU03KJPwA==", null, false, "89f4f2c9-2338-476d-9735-bfb3c842b63f", false, "varnasharks.afc@gmail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "254d37dd-51e3-4cca-8aa6-a81e98e50d09", "ddimitar98@gmail.com", false, false, null, "DDIMITAR98@GMAIL.COM", "ddimitar98@gmail.com", "AQAAAAIAAYagAAAAEJmq/93XDB84/8+DDuSHky8V4UQXypm4YUsJRbXL6+gvo4CxS6/PNNdXj8+sjfirHw==", null, false, "c8cfaf3f-924c-4a1a-bc69-a7c69ed0945b", false, "ddimitar98@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Plays",
                columns: new[] { "Id", "DateAndTime", "Description", "Genre", "Location", "PlayImagesURLs", "PlayVideosURLs", "TicketURL", "Title" },
                values: new object[] { 1, new DateTime(2025, 12, 15, 19, 30, 0, 0, DateTimeKind.Unspecified), "Romeo and Juliet is a tragedy written by William Shakespeare early in his career about two young star-crossed lovers whose deaths ultimately reconcile their feuding families. It was among Shakespeare's most popular plays during his lifetime and along with Hamlet, is one of his most frequently performed plays. Today, the title characters are regarded as archetypal young lovers.", "Comedy", "Opera Varna, CenterOdesos, pl. \"Nezavisimost\" 1, 9000 Varna", "[\"C:\\\\Users\\\\ddimi\\\\source\\\\repos\\\\TheatherWebProject\\\\TheatherWebProject.Infrastructure\\\\Data\\\\LocalImageSotrage\\\\IMG_0843(i).jpg\",\"C:\\\\Users\\\\ddimi\\\\source\\\\repos\\\\TheatherWebProject\\\\TheatherWebProject.Infrastructure\\\\Data\\\\LocalImageSotrage\\\\dyslexia card.jpg\"]", "[\"https://www.youtube.com/watch?v=CCI3XPFjqn8\"]", "https://www.eventim.bg/bg/", "Romeo and Juliet" });

            migrationBuilder.InsertData(
                table: "ActorsPlays",
                columns: new[] { "ActorId", "PlayId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "DisplayName", "IdentityUserId" },
                values: new object[] { 1, "Dimitar Dimitrov", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ApplicationUserId", "Content", "CreatedOn", "PlayId" },
                values: new object[] { 1, 1, "This is a great play! I highly recommend it to everyone!", new DateTime(2025, 12, 15, 19, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ActorsPlays_PlayId",
                table: "ActorsPlays",
                column: "PlayId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserFavouritePlays_FavouritePlaysId",
                table: "ApplicationUserFavouritePlays",
                column: "FavouritePlaysId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserGoingToPlays_GoingToPlaysId",
                table: "ApplicationUserGoingToPlays",
                column: "GoingToPlaysId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserLikedPlays_LikedPlaysId",
                table: "ApplicationUserLikedPlays",
                column: "LikedPlaysId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_IdentityUserId",
                table: "ApplicationUsers",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserWatchedPlays_WatchedPlaysId",
                table: "ApplicationUserWatchedPlays",
                column: "WatchedPlaysId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ApplicationUserId",
                table: "Comments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PlayId",
                table: "Comments",
                column: "PlayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorsPlays");

            migrationBuilder.DropTable(
                name: "ApplicationUserFavouritePlays");

            migrationBuilder.DropTable(
                name: "ApplicationUserGoingToPlays");

            migrationBuilder.DropTable(
                name: "ApplicationUserLikedPlays");

            migrationBuilder.DropTable(
                name: "ApplicationUserWatchedPlays");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Plays");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
