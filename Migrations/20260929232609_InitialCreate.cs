using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace termProjectPhotoApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gallery",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Credit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gallery", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Gallery",
                columns: new[] { "ID", "Credit", "Description", "ImageUrl", "PhotoType", "Title" },
                values: new object[,]
                {
                    { 1, "Andrew Camp", "Mountain Goat", "/images/goat.jpg", null, "GOAT" },
                    { 2, "Andrew Camp", "Mountain", "/images/mountain.jpg", null, "Continental Divide" },
                    { 3, "Andrew Camp", "Mesa in front of mountain", "/images/mesaMountain.jpg", null, "Mesa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gallery");
        }
    }
}
