using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class Ford : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 6, 30, 15, 49, 28, 383, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 6, 30, 15, 49, 28, 386, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 6, 30, 15, 49, 28, 386, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "Date", "Title" },
                values: new object[] { 4, "Sally", "Lorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem IpsumLorem Ipsum", 2, new DateTime(2019, 6, 30, 15, 49, 28, 386, DateTimeKind.Local), "Ford GT" });

            migrationBuilder.InsertData(
                table: "TagPostsdb",
                columns: new[] { "TagId", "PostId", "Id" },
                values: new object[] { 3, 4, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TagPostsdb",
                keyColumns: new[] { "TagId", "PostId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 6, 30, 15, 1, 6, 887, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 6, 30, 15, 1, 6, 890, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 6, 30, 15, 1, 6, 890, DateTimeKind.Local));
        }
    }
}
