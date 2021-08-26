using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject.Migrations
{
    public partial class Deploy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomCollections_AspNetUsers_UserId",
                table: "CustomCollections");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CustomCollections",
                newName: "IUserId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomCollections_UserId",
                table: "CustomCollections",
                newName: "IX_CustomCollections_IUserId");

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "CustomItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_CustomCollections_AspNetUsers_IUserId",
                table: "CustomCollections",
                column: "IUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomCollections_AspNetUsers_IUserId",
                table: "CustomCollections");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "CustomItems");

            migrationBuilder.RenameColumn(
                name: "IUserId",
                table: "CustomCollections",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomCollections_IUserId",
                table: "CustomCollections",
                newName: "IX_CustomCollections_UserId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7be31283-195b-4d9e-b225-18d39cf80b2b",
                column: "ConcurrencyStamp",
                value: "57cb98e2-98a0-4298-b928-ee1bce87b024");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a8a534e9-8e3a-47c7-ba0d-e0ed7678bbf4", "AQAAAAEAACcQAAAAEFISXn7Z52KZMVo3Vzhog8AnBaTJ+raQKL9u2It2AvJpH7Lx4pgDc0ltIf1EDyhInQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomCollections_AspNetUsers_UserId",
                table: "CustomCollections",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
