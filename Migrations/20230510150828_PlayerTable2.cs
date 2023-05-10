using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_ef_players.Migrations
{
    /// <inheritdoc />
    public partial class PlayerTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "players_table",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayerScore = table.Column<int>(type: "int", nullable: false),
                    PlayerMatches = table.Column<int>(type: "int", nullable: false),
                    PlayerVictories = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_players_table", x => x.PlayerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "players_table");
        }
    }
}
