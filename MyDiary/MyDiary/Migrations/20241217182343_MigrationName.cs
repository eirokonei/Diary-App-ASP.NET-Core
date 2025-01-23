using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDiary.Migrations
{
    /// <inheritdoc />
    public partial class MigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 12, 18, 0, 23, 42, 947, DateTimeKind.Local).AddTicks(8847));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 12, 18, 0, 17, 21, 615, DateTimeKind.Local).AddTicks(2523));
        }
    }
}
