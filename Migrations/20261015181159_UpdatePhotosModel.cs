using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace termProjectPhotoApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePhotosModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Gallery",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Gallery",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Credit",
                table: "Gallery",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Gallery",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Gallery",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "Location" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "Location" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Gallery",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "Location" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Gallery");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Gallery");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Gallery",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Gallery",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Credit",
                table: "Gallery",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
