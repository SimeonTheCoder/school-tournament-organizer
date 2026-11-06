using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TournamentOrganizer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FollowableIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Followable_FollowableId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "FollowableType",
                table: "Followable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "FollowableId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Class",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Followable_FollowableId",
                table: "AspNetUsers",
                column: "FollowableId",
                principalTable: "Followable",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Followable_FollowableId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FollowableType",
                table: "Followable");

            migrationBuilder.AlterColumn<string>(
                name: "FollowableId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Class",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Followable_FollowableId",
                table: "AspNetUsers",
                column: "FollowableId",
                principalTable: "Followable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
