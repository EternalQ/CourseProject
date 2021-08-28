using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject.Migrations
{
    public partial class AddImagePublicId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePublicId",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePublicId",
                table: "CustomCollections");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7be31283-195b-4d9e-b225-18d39cf80b2b",
                column: "ConcurrencyStamp",
                value: "c732ab06-fe2d-4bb1-9037-c72ce13cf7d8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13a1c283-50a0-4891-aefa-f8ca7a7b769e", "AQAAAAEAACcQAAAAEBIRG2qsubz69ePTXaJDxpV8eq8bzd7Kj5W7DMGjO/b3EcYHdE1Q3JGIG00hk/364w==" });
        }
    }
}
