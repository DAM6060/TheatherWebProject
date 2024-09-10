using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatherWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class USertoApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "UserFavouritePlays");

            migrationBuilder.DropTable(
                name: "UserGoingToPlays");

            migrationBuilder.DropTable(
                name: "UserLikedPlays");

            migrationBuilder.DropTable(
                name: "UserWatchedPlays");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Comments",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                newName: "IX_Comments_ApplicationUserId");

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ApplicationUsers_ApplicationUserId",
                table: "Comments",
                column: "ApplicationUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ApplicationUsers_ApplicationUserId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "ApplicationUserFavouritePlays");

            migrationBuilder.DropTable(
                name: "ApplicationUserGoingToPlays");

            migrationBuilder.DropTable(
                name: "ApplicationUserLikedPlays");

            migrationBuilder.DropTable(
                name: "ApplicationUserWatchedPlays");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Comments",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ApplicationUserId",
                table: "Comments",
                newName: "IX_Comments_UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
