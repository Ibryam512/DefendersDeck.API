using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DefendersDeck.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ImageUrl" },
                values: new object[] { new DateTime(2025, 1, 14, 22, 0, 0, 0, DateTimeKind.Utc), "fire-arrows.png" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 1, 14, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 1, 14, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 1, 14, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 1, 14, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2025, 1, 14, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2025, 1, 14, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ImageUrl" },
                values: new object[] { new DateTime(2025, 1, 14, 22, 0, 0, 0, DateTimeKind.Utc), "health-potion.png" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ImageUrl" },
                values: new object[] { new DateTime(2025, 1, 14, 22, 0, 0, 0, DateTimeKind.Utc), "shadow-army.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "ImageUrl" },
                values: new object[] { new DateTime(2025, 1, 8, 22, 0, 0, 0, DateTimeKind.Utc), "" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 1, 8, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 1, 8, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 1, 8, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 1, 8, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2025, 1, 8, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2025, 1, 8, 22, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationDate", "ImageUrl" },
                values: new object[] { new DateTime(2025, 1, 8, 22, 0, 0, 0, DateTimeKind.Utc), "" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationDate", "ImageUrl" },
                values: new object[] { new DateTime(2025, 1, 8, 22, 0, 0, 0, DateTimeKind.Utc), "" });
        }
    }
}
