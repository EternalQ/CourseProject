using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject.Migrations
{
    public partial class RemoveNameFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Check1_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Check2_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Check3_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Date1_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Date2_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Date3_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Num1_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Num2_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Num3_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Str1_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Str2_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Str3_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Txt1_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Txt2_name",
                table: "CustomItems");

            migrationBuilder.DropColumn(
                name: "Txt3_name",
                table: "CustomItems");

            migrationBuilder.AddColumn<string>(
                name: "Check1_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Check2_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Check3_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date1_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date2_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date3_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Num1_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Num2_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Num3_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Str1_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Str2_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Str3_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Txt1_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Txt2_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Txt3_name",
                table: "CustomCollections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7be31283-195b-4d9e-b225-18d39cf80b2b",
                column: "ConcurrencyStamp",
                value: "edd87191-7e9d-4f69-bdd8-c59c88832a42");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9a95ad3-8f11-4bc2-bd0e-1afe2c522532", "AQAAAAEAACcQAAAAEPT/ZITziPWljXYcwepVooOklPYZ222BctBhlYFSWyT5pL0Oz93tW/wUl/InOmlSYg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Check1_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Check2_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Check3_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Date1_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Date2_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Date3_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Num1_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Num2_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Num3_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Str1_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Str2_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Str3_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Txt1_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Txt2_name",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Txt3_name",
                table: "CustomCollections");

            migrationBuilder.AddColumn<string>(
                name: "Check1_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Check2_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Check3_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date1_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date2_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date3_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Num1_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Num2_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Num3_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Str1_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Str2_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Str3_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Txt1_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Txt2_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Txt3_name",
                table: "CustomItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7be31283-195b-4d9e-b225-18d39cf80b2b",
                column: "ConcurrencyStamp",
                value: "5f9883bd-0321-4d43-84ba-2a6c398be095");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76a37ee5-c388-478f-8af1-b9ea8d958822", "AQAAAAEAACcQAAAAEAW53pgaCQKjmbN8MfdPysp0GYyV+p/ezubupf2gG1VPRsY6cplvPs9PsSH+sn0rog==" });
        }
    }
}
