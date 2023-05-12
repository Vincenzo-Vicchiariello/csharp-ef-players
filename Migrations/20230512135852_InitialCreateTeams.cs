using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_ef_players.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateTeams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlayerTeam",
                table: "players_table",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "players_table",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "teams_table",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamCoach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamColours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams_table", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_teams_table_teams_table_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "teams_table",
                        principalColumn: "TeamId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_teams_table_TeamId1",
                table: "teams_table",
                column: "TeamId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "teams_table");

            migrationBuilder.DropColumn(
                name: "PlayerTeam",
                table: "players_table");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "players_table");
        }
    }
}
