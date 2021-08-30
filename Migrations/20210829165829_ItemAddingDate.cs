using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject.Migrations
{
    public partial class ItemAddingDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddingDate",
                table: "CustomItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7be31283-195b-4d9e-b225-18d39cf80b2b",
                column: "ConcurrencyStamp",
                value: "9a95264b-2e4a-4b8f-b516-f079c2cc8372");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "962b9265-e5fb-4b28-8245-8c29ee3f5ddb", "AQAAAAEAACcQAAAAEBg5EKRwUr1uyVZsCkNMn4RMJWjlKWOHpw8TnRZQpubauQfpq95ZN/VjpHlRr+E/4g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddingDate",
                table: "CustomItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7be31283-195b-4d9e-b225-18d39cf80b2b",
                column: "ConcurrencyStamp",
                value: "96dba311-90eb-4620-a97c-acb6ea516405");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0e6cb72f-cedd-4f76-9c3c-117dc2e726e7", "AQAAAAEAACcQAAAAEHUaMMCcAsmIluf0HkhbEp7oG1R2Kevim+EK1cExgefCTAHVy5fYmr4Bkn65KRkWvQ==" });
        }
    }
}
