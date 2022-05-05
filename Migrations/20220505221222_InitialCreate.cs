using Microsoft.EntityFrameworkCore.Migrations;

namespace kwFinalProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    userID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    pokeName = table.Column<string>(nullable: true),
                    attack = table.Column<int>(nullable: false),
                    defense = table.Column<int>(nullable: false),
                    spAttack = table.Column<int>(nullable: false),
                    spDefense = table.Column<int>(nullable: false),
                    speed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.userID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
