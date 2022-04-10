using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelerGuideApp.Migrations
{
    public partial class ModifyDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItineraryLocation_Travels_TravelItineraryId",
                table: "ItineraryLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_Travels_Users_UserId",
                table: "Travels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Travels",
                table: "Travels");

            migrationBuilder.RenameTable(
                name: "Travels",
                newName: "TravelItineraries");

            migrationBuilder.RenameIndex(
                name: "IX_Travels_UserId",
                table: "TravelItineraries",
                newName: "IX_TravelItineraries_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TravelItineraries",
                table: "TravelItineraries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItineraryLocation_TravelItineraries_TravelItineraryId",
                table: "ItineraryLocation",
                column: "TravelItineraryId",
                principalTable: "TravelItineraries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelItineraries_Users_UserId",
                table: "TravelItineraries",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItineraryLocation_TravelItineraries_TravelItineraryId",
                table: "ItineraryLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelItineraries_Users_UserId",
                table: "TravelItineraries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TravelItineraries",
                table: "TravelItineraries");

            migrationBuilder.RenameTable(
                name: "TravelItineraries",
                newName: "Travels");

            migrationBuilder.RenameIndex(
                name: "IX_TravelItineraries_UserId",
                table: "Travels",
                newName: "IX_Travels_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Travels",
                table: "Travels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItineraryLocation_Travels_TravelItineraryId",
                table: "ItineraryLocation",
                column: "TravelItineraryId",
                principalTable: "Travels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Travels_Users_UserId",
                table: "Travels",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
