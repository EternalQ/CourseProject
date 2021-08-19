﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descrip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    Num1_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Num2_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Num3_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Str1_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Str2_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Str3_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Txt1_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Txt2_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Txt3_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Date1_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Date2_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Date3_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Check1_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Check2_visibility = table.Column<bool>(type: "bit", nullable: false),
                    Check3_visibility = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomCollections_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomCollections_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectionId = table.Column<int>(type: "int", nullable: false),
                    Num1_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num2_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num3_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num1 = table.Column<int>(type: "int", nullable: false),
                    Num2 = table.Column<int>(type: "int", nullable: false),
                    Num3 = table.Column<int>(type: "int", nullable: false),
                    Str1_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str2_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str3_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Str3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Txt1_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Txt2_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Txt3_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Txt1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Txt2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Txt3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date1_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date2_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date3_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date3 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Check1_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Check2_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Check3_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Check1 = table.Column<bool>(type: "bit", nullable: false),
                    Check2 = table.Column<bool>(type: "bit", nullable: false),
                    Check3 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomItems_CustomCollections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "CustomCollections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7be31283-195b-4d9e-b225-18d39cf80b2b", "bfa6968c-17a1-43db-9703-4ef8d3bb05c7", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7", 0, "3dec69bd-f347-4985-94e1-797bae415360", "admin@mail.com", true, false, null, "ADMIN@MAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEF/ZnD7cz4otEi6FiIeVDUr2jIsm1R19DqD9DNBCbw5npt0hQWwqkxTOqrpU7xwtYQ==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7be31283-195b-4d9e-b225-18d39cf80b2b", "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CustomCollections_SubjectId",
                table: "CustomCollections",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomCollections_UserId",
                table: "CustomCollections",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomItems_CollectionId",
                table: "CustomItems",
                column: "CollectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CustomItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CustomCollections");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}
