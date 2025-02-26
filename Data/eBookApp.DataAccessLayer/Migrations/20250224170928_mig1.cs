using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBookApp.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Authors",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Authors",
                newName: "Img");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AppUsers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 2, 24, 20, 9, 27, 495, DateTimeKind.Local).AddTicks(7515), new Guid("98ca239e-93ab-4864-82a6-96206e73bbd8") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 20, 9, 27, 519, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 24, 20, 9, 27, 520, DateTimeKind.Local).AddTicks(3519));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "Img",
                table: "Authors",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Authors",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AppUsers",
                type: "varchar(50",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UserGuid" },
                values: new object[] { new DateTime(2025, 1, 29, 21, 30, 29, 175, DateTimeKind.Local).AddTicks(4858), new Guid("e6c0ee22-e5f9-45f0-aeb4-6ecef2036905") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 21, 30, 29, 177, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 21, 30, 29, 177, DateTimeKind.Local).AddTicks(4692));
        }
    }
}
