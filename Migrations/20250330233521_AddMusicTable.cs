using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTSCataloAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddMusicTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Music_Albuns_AlbumId",
                table: "Music");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Music",
                table: "Music");

            migrationBuilder.RenameTable(
                name: "Music",
                newName: "Musics");

            migrationBuilder.RenameIndex(
                name: "IX_Music_AlbumId",
                table: "Musics",
                newName: "IX_Musics_AlbumId");

            migrationBuilder.AddColumn<string>(
                name: "Artista",
                table: "Musics",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Musics",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Musics",
                table: "Musics",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Musics_Albuns_AlbumId",
                table: "Musics",
                column: "AlbumId",
                principalTable: "Albuns",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musics_Albuns_AlbumId",
                table: "Musics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Musics",
                table: "Musics");

            migrationBuilder.DropColumn(
                name: "Artista",
                table: "Musics");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Musics");

            migrationBuilder.RenameTable(
                name: "Musics",
                newName: "Music");

            migrationBuilder.RenameIndex(
                name: "IX_Musics_AlbumId",
                table: "Music",
                newName: "IX_Music_AlbumId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Music",
                table: "Music",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Albuns_AlbumId",
                table: "Music",
                column: "AlbumId",
                principalTable: "Albuns",
                principalColumn: "Id");
        }
    }
}
