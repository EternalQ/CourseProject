using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject.Migrations
{
    public partial class CommentsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomCollections_Subject_SubjectId",
                table: "CustomCollections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "Subjects");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_CustomItems_CustomItemId",
                        column: x => x.CustomItemId,
                        principalTable: "CustomItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CustomItemId",
                table: "Comments",
                column: "CustomItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomCollections_Subjects_SubjectId",
                table: "CustomCollections",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomCollections_Subjects_SubjectId",
                table: "CustomCollections");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Subject");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CustomCollections_Subject_SubjectId",
                table: "CustomCollections",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
