using Microsoft.EntityFrameworkCore.Migrations;

namespace NewWords.Migrations
{
    public partial class LastResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LastResults",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    AmountGuessed = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<int>(nullable: false),
                    NativeLanguage = table.Column<int>(nullable: false),
                    GuessedLanguage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastResults", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LastResults");
        }
    }
}
