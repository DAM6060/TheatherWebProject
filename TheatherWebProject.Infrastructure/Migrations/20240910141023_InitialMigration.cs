using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatherWebProject.Data.Migrations
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
                    NameFirst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameLast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorPlay",
                columns: table => new
                {
                    ActorsId = table.Column<int>(type: "int", nullable: false),
                    PlaysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorPlay", x => new { x.ActorsId, x.PlaysId });
                    table.ForeignKey(
                        name: "FK_ActorPlay_Actors_ActorsId",
                        column: x => x.ActorsId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorPlay_Plays_PlaysId",
                        column: x => x.PlaysId,
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
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Plays_PlayId",
                        column: x => x.PlayId,
                        principalTable: "Plays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFavouritePlays",
                columns: table => new
                {
                    FavouritePlaysId = table.Column<int>(type: "int", nullable: false),
                    UsersFavouritePlaysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavouritePlays", x => new { x.FavouritePlaysId, x.UsersFavouritePlaysId });
                    table.ForeignKey(
                        name: "FK_UserFavouritePlays_Plays_FavouritePlaysId",
                        column: x => x.FavouritePlaysId,
                        principalTable: "Plays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFavouritePlays_Users_UsersFavouritePlaysId",
                        column: x => x.UsersFavouritePlaysId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGoingToPlays",
                columns: table => new
                {
                    GoingToPlaysId = table.Column<int>(type: "int", nullable: false),
                    UsersGoingToPlaysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGoingToPlays", x => new { x.GoingToPlaysId, x.UsersGoingToPlaysId });
                    table.ForeignKey(
                        name: "FK_UserGoingToPlays_Plays_GoingToPlaysId",
                        column: x => x.GoingToPlaysId,
                        principalTable: "Plays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGoingToPlays_Users_UsersGoingToPlaysId",
                        column: x => x.UsersGoingToPlaysId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLikedPlays",
                columns: table => new
                {
                    LikedPlaysId = table.Column<int>(type: "int", nullable: false),
                    UsersLikedPlaysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLikedPlays", x => new { x.LikedPlaysId, x.UsersLikedPlaysId });
                    table.ForeignKey(
                        name: "FK_UserLikedPlays_Plays_LikedPlaysId",
                        column: x => x.LikedPlaysId,
                        principalTable: "Plays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLikedPlays_Users_UsersLikedPlaysId",
                        column: x => x.UsersLikedPlaysId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWatchedPlays",
                columns: table => new
                {
                    UsersWatchedPlaysId = table.Column<int>(type: "int", nullable: false),
                    WatchedPlaysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWatchedPlays", x => new { x.UsersWatchedPlaysId, x.WatchedPlaysId });
                    table.ForeignKey(
                        name: "FK_UserWatchedPlays_Plays_WatchedPlaysId",
                        column: x => x.WatchedPlaysId,
                        principalTable: "Plays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWatchedPlays_Users_UsersWatchedPlaysId",
                        column: x => x.UsersWatchedPlaysId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorPlay_PlaysId",
                table: "ActorPlay",
                column: "PlaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PlayId",
                table: "Comments",
                column: "PlayId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavouritePlays_UsersFavouritePlaysId",
                table: "UserFavouritePlays",
                column: "UsersFavouritePlaysId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGoingToPlays_UsersGoingToPlaysId",
                table: "UserGoingToPlays",
                column: "UsersGoingToPlaysId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLikedPlays_UsersLikedPlaysId",
                table: "UserLikedPlays",
                column: "UsersLikedPlaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdentityUserId",
                table: "Users",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWatchedPlays_WatchedPlaysId",
                table: "UserWatchedPlays",
                column: "WatchedPlaysId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorPlay");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "UserFavouritePlays");

            migrationBuilder.DropTable(
                name: "UserGoingToPlays");

            migrationBuilder.DropTable(
                name: "UserLikedPlays");

            migrationBuilder.DropTable(
                name: "UserWatchedPlays");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Plays");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
