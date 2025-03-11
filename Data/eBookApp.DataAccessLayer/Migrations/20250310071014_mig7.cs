using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBookApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 3, 10, 10, 10, 13, 686, DateTimeKind.Local).AddTicks(2959), new Guid("22466306-421a-4c1b-b46e-f73c83888a24") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 10, 10, 10, 13, 688, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 10, 10, 10, 13, 688, DateTimeKind.Local).AddTicks(3804));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
