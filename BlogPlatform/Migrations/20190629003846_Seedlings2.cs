using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class Seedlings2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TagPostsdb",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 6, 28, 20, 38, 45, 857, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TagPostsdb",
                keyColumns: new[] { "TagId", "PostId" },
                keyValues: new object[] { 1, 1 },
                column: "Id",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "TagPostsdb");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 6, 28, 20, 28, 0, 610, DateTimeKind.Local));
        }
    }
}
