using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatherWebProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorsPlays_Actors_ActorId",
                table: "ActorsPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorsPlays_Plays_PlayId",
                table: "ActorsPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserFavouritePlays_ApplicationUsers_ApplicationUsersFavouritePlaysId",
                table: "ApplicationUserFavouritePlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserFavouritePlays_Plays_FavouritePlaysId",
                table: "ApplicationUserFavouritePlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGoingToPlays_ApplicationUsers_ApplicationUsersGoingToPlaysId",
                table: "ApplicationUserGoingToPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGoingToPlays_Plays_GoingToPlaysId",
                table: "ApplicationUserGoingToPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserLikedPlays_ApplicationUsers_ApplicationUsersLikedPlaysId",
                table: "ApplicationUserLikedPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserLikedPlays_Plays_LikedPlaysId",
                table: "ApplicationUserLikedPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_AspNetUsers_IdentityUserId",
                table: "ApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserWatchedPlays_ApplicationUsers_ApplicationUsersWatchedPlaysId",
                table: "ApplicationUserWatchedPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserWatchedPlays_Plays_WatchedPlaysId",
                table: "ApplicationUserWatchedPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ApplicationUsers_ApplicationUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Plays_PlayId",
                table: "Comments");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsPlays_Actors_ActorId",
                table: "ActorsPlays",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsPlays_Plays_PlayId",
                table: "ActorsPlays",
                column: "PlayId",
                principalTable: "Plays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserFavouritePlays_ApplicationUsers_ApplicationUsersFavouritePlaysId",
                table: "ApplicationUserFavouritePlays",
                column: "ApplicationUsersFavouritePlaysId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserFavouritePlays_Plays_FavouritePlaysId",
                table: "ApplicationUserFavouritePlays",
                column: "FavouritePlaysId",
                principalTable: "Plays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGoingToPlays_ApplicationUsers_ApplicationUsersGoingToPlaysId",
                table: "ApplicationUserGoingToPlays",
                column: "ApplicationUsersGoingToPlaysId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGoingToPlays_Plays_GoingToPlaysId",
                table: "ApplicationUserGoingToPlays",
                column: "GoingToPlaysId",
                principalTable: "Plays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserLikedPlays_ApplicationUsers_ApplicationUsersLikedPlaysId",
                table: "ApplicationUserLikedPlays",
                column: "ApplicationUsersLikedPlaysId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserLikedPlays_Plays_LikedPlaysId",
                table: "ApplicationUserLikedPlays",
                column: "LikedPlaysId",
                principalTable: "Plays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_AspNetUsers_IdentityUserId",
                table: "ApplicationUsers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserWatchedPlays_ApplicationUsers_ApplicationUsersWatchedPlaysId",
                table: "ApplicationUserWatchedPlays",
                column: "ApplicationUsersWatchedPlaysId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserWatchedPlays_Plays_WatchedPlaysId",
                table: "ApplicationUserWatchedPlays",
                column: "WatchedPlaysId",
                principalTable: "Plays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ApplicationUsers_ApplicationUserId",
                table: "Comments",
                column: "ApplicationUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Plays_PlayId",
                table: "Comments",
                column: "PlayId",
                principalTable: "Plays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorsPlays_Actors_ActorId",
                table: "ActorsPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorsPlays_Plays_PlayId",
                table: "ActorsPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserFavouritePlays_ApplicationUsers_ApplicationUsersFavouritePlaysId",
                table: "ApplicationUserFavouritePlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserFavouritePlays_Plays_FavouritePlaysId",
                table: "ApplicationUserFavouritePlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGoingToPlays_ApplicationUsers_ApplicationUsersGoingToPlaysId",
                table: "ApplicationUserGoingToPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGoingToPlays_Plays_GoingToPlaysId",
                table: "ApplicationUserGoingToPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserLikedPlays_ApplicationUsers_ApplicationUsersLikedPlaysId",
                table: "ApplicationUserLikedPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserLikedPlays_Plays_LikedPlaysId",
                table: "ApplicationUserLikedPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_AspNetUsers_IdentityUserId",
                table: "ApplicationUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserWatchedPlays_ApplicationUsers_ApplicationUsersWatchedPlaysId",
                table: "ApplicationUserWatchedPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserWatchedPlays_Plays_WatchedPlaysId",
                table: "ApplicationUserWatchedPlays");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ApplicationUsers_ApplicationUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Plays_PlayId",
                table: "Comments");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsPlays_Actors_ActorId",
                table: "ActorsPlays",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsPlays_Plays_PlayId",
                table: "ActorsPlays",
                column: "PlayId",
                principalTable: "Plays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserFavouritePlays_ApplicationUsers_ApplicationUsersFavouritePlaysId",
                table: "ApplicationUserFavouritePlays",
                column: "ApplicationUsersFavouritePlaysId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserFavouritePlays_Plays_FavouritePlaysId",
                table: "ApplicationUserFavouritePlays",
                column: "FavouritePlaysId",
                principalTable: "Plays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGoingToPlays_ApplicationUsers_ApplicationUsersGoingToPlaysId",
                table: "ApplicationUserGoingToPlays",
                column: "ApplicationUsersGoingToPlaysId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGoingToPlays_Plays_GoingToPlaysId",
                table: "ApplicationUserGoingToPlays",
                column: "GoingToPlaysId",
                principalTable: "Plays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserLikedPlays_ApplicationUsers_ApplicationUsersLikedPlaysId",
                table: "ApplicationUserLikedPlays",
                column: "ApplicationUsersLikedPlaysId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserLikedPlays_Plays_LikedPlaysId",
                table: "ApplicationUserLikedPlays",
                column: "LikedPlaysId",
                principalTable: "Plays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_AspNetUsers_IdentityUserId",
                table: "ApplicationUsers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserWatchedPlays_ApplicationUsers_ApplicationUsersWatchedPlaysId",
                table: "ApplicationUserWatchedPlays",
                column: "ApplicationUsersWatchedPlaysId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserWatchedPlays_Plays_WatchedPlaysId",
                table: "ApplicationUserWatchedPlays",
                column: "WatchedPlaysId",
                principalTable: "Plays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ApplicationUsers_ApplicationUserId",
                table: "Comments",
                column: "ApplicationUserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Plays_PlayId",
                table: "Comments",
                column: "PlayId",
                principalTable: "Plays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
