using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7be31283-195b-4d9e-b225-18d39cf80b2b",
                column: "ConcurrencyStamp",
                value: "4517bce6-30e1-4384-89a8-5650b434999d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b473b00-a2fc-442a-a968-1bf09d3a8931", "AQAAAAEAACcQAAAAEE/2ykNqUh04JUHIMoAszdJ/qmtKkzqVfPMrTynl9d3DTHf9XNKFAY/QjbPGh0+hmA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7be31283-195b-4d9e-b225-18d39cf80b2b",
                column: "ConcurrencyStamp",
                value: "bfa6968c-17a1-43db-9703-4ef8d3bb05c7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3dec69bd-f347-4985-94e1-797bae415360", "AQAAAAEAACcQAAAAEF/ZnD7cz4otEi6FiIeVDUr2jIsm1R19DqD9DNBCbw5npt0hQWwqkxTOqrpU7xwtYQ==" });
        }
    }
}
