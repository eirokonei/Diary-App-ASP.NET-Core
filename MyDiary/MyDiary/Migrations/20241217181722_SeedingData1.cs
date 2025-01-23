using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDiary.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 12, 18, 0, 17, 21, 615, DateTimeKind.Local).AddTicks(2523));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 12, 18, 0, 8, 8, 181, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[] { 2, "Alhamdulillah", new DateTime(2024, 12, 18, 0, 8, 8, 181, DateTimeKind.Local).AddTicks(3884), "Allah" });
        }
    }
}
