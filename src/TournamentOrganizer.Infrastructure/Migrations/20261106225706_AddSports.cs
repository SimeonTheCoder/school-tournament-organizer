using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TournamentOrganizer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScoringType = table.Column<int>(type: "int", nullable: false),
                    FollowableId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sports_Followable_FollowableId",
                        column: x => x.FollowableId,
                        principalTable: "Followable",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sports_FollowableId",
                table: "Sports",
                column: "FollowableId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
