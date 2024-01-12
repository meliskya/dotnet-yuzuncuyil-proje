using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetYuzuncuYilProjesi.Repository.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MusicDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "SongId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MusicDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "SongId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MusicDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "SongId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 2, 26, 35, 1, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 2, 26, 35, 1, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 2, 26, 35, 1, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 2, 26, 35, 1, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 2, 26, 35, 1, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 2, 26, 35, 1, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 2, 26, 35, 1, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 2, 26, 35, 1, DateTimeKind.Local).AddTicks(8160));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MusicDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "SongId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MusicDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "SongId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MusicDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "SongId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 12, 1, 50, 53, 571, DateTimeKind.Local).AddTicks(3465));
        }
    }
}
