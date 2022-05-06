using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaxAmmonsFinalProject.Migrations
{
    public partial class Stats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    StatsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Strength = table.Column<string>(type: "INTEGER", nullable: false),
                    Speed = table.Column<string>(type: "INTEGER", nullable: false),
                    Intelligence = table.Column<string>(type: "INTEGER", nullable: false),
                    Charisma = table.Column<string>(type: "INTEGER", nullable: false),
                    Armor = table.Column<string>(type: "INTEGER", nullable: false)
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.StatsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Symptoms");
        }
    }
}