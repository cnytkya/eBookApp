using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBookApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Mig33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 3, 4, 22, 49, 5, 696, DateTimeKind.Local).AddTicks(3246), new Guid("a99285a2-0ddb-467e-8217-d4340e53a292") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 22, 49, 5, 698, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 22, 49, 5, 698, DateTimeKind.Local).AddTicks(3243));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 3, 3, 20, 15, 34, 845, DateTimeKind.Local).AddTicks(104), new Guid("0fe47849-5348-483c-bb62-7fe2c47c3c5a") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 20, 15, 34, 868, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 20, 15, 34, 868, DateTimeKind.Local).AddTicks(3637));
        }
    }
}
