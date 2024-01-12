using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetYuzuncuYilProjesi.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaylistName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Singer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayListId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_PlayLists_PlayListId",
                        column: x => x.PlayListId,
                        principalTable: "PlayLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusicDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lyrics = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    NumberOfLikes = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusicDetails_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PlayLists",
                columns: new[] { "Id", "CreatedDate", "PlaylistName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3361), "Classical", null },
                    { 2, new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3372), "Jazz", null },
                    { 3, new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3373), "Rock", null },
                    { 4, new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3374), "Blues", null }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "CreatedDate", "Duration", "PlayListId", "Singer", "SongName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3461), "9.30 dakika", 1, "Vivaldi", "La Follia", null },
                    { 2, new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3463), "2.47 dakika", 2, "Dean Martin", "Everybody Loves Somebody", null },
                    { 3, new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3464), "4.15 dakika", 3, "Cheap Trick", "Surrender", null },
                    { 4, new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3465), "2.35 dakika", 4, "Etta James", "I'd Rather Go Blind", null }
                });

            migrationBuilder.InsertData(
                table: "MusicDetails",
                columns: new[] { "Id", "Lyrics", "NumberOfLikes", "ReleaseYear", "SongId" },
                values: new object[,]
                {
                    { 1, "klasikmüziksöz", 5464654, 1996, 1 },
                    { 2, "cazmüziksöz", 46565, 1896, 1 },
                    { 3, "rockmüziksöz", 98798, 1976, 1 },
                    { 4, "bluesmüziksöz", 1531, 1953, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusicDetails_SongId",
                table: "MusicDetails",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_PlayListId",
                table: "Songs",
                column: "PlayListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicDetails");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "PlayLists");
        }
    }
}
