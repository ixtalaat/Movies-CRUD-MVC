using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD.Movies.Migrations
{
    /// <inheritdoc />
    public partial class ModfiyMoviesGenresTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StroyLine",
                table: "Movies",
                newName: "StoryLine");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StoryLine",
                table: "Movies",
                newName: "StroyLine");
        }
    }
}
