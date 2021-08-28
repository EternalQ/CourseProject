using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject.Migrations
{
    public partial class IdGeneration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7be31283-195b-4d9e-b225-18d39cf80b2b",
                column: "ConcurrencyStamp",
                value: "e412e6ab-482e-43c5-903c-abda22735669");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3df72b0f-1baa-4369-aee5-647f386a2c5c", "AQAAAAEAACcQAAAAEPf6JAT8Qky+9ENDa5YzuNXAHdtS1u9DfJn3FNaV71QfTgmqsRw7qFdRVPhouV8X5g==" });
        }
    }
}
