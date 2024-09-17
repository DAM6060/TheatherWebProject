using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatherWebProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDeleteBehaviourToRestricted : Migration
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
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

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
                values: new object[] { "44b31f62-7d5a-4d18-a386-9cb47eb0d94d", "AQAAAAIAAYagAAAAEGaxtPY+y6+tJgiEaf9HH3OEYNTN5RO30rSzoA/3voRUsxApzu525do0zhNNvdCDxg==", "3acc226e-edba-4ccc-9850-ad6686a6e7df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18c340af-db76-4e27-b971-4a24d4e96eaa", "AQAAAAIAAYagAAAAEEORQxUUKWBJjwv/KLTw1h4y4DiGvmhsjIPX4osxhkct77HIO7rfZMgr4F7YUHmQSw==", "d486541f-5bc0-4df5-bfd8-864689dfc84e" });

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
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
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
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

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
                values: new object[] { "6549b8af-08dd-4f0d-8dc9-0fced5c94fe9", "AQAAAAIAAYagAAAAEFyOMgPp153rvaoGhzyjNnpUxscTyV+D575vZ58OD8IB3MLAz6bF+0sq/TU03KJPwA==", "89f4f2c9-2338-476d-9735-bfb3c842b63f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "254d37dd-51e3-4cca-8aa6-a81e98e50d09", "AQAAAAIAAYagAAAAEJmq/93XDB84/8+DDuSHky8V4UQXypm4YUsJRbXL6+gvo4CxS6/PNNdXj8+sjfirHw==", "c8cfaf3f-924c-4a1a-bc69-a7c69ed0945b" });

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
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
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
