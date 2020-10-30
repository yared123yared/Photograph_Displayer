using Microsoft.EntityFrameworkCore.Migrations;

namespace photogrph_Displayer_api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photographer",
                columns: table => new
                {
                    PhotographerId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FName = table.Column<string>(nullable: true),
                    LName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    WorkTitle = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ProfilePictureName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photographer", x => new { x.PhotographerId, x.Email });
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotosId = table.Column<int>(nullable: false),
                    PhotographerEmail = table.Column<string>(nullable: false),
                    PhotosName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => new { x.PhotographerEmail, x.PhotosId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photographer");

            migrationBuilder.DropTable(
                name: "Photos");
        }
    }
}
