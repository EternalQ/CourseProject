﻿// <auto-generated />
using System;
using CourseProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210825134521_RemoveNameFields")]
    partial class RemoveNameFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseProject.Models.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomItemId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CustomItemId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("CourseProject.Models.Entities.CustomCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Check1_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Check1_visibility")
                        .HasColumnType("bit");

                    b.Property<string>("Check2_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Check2_visibility")
                        .HasColumnType("bit");

                    b.Property<string>("Check3_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Check3_visibility")
                        .HasColumnType("bit");

                    b.Property<string>("Date1_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Date1_visibility")
                        .HasColumnType("bit");

                    b.Property<string>("Date2_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Date2_visibility")
                        .HasColumnType("bit");

                    b.Property<string>("Date3_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Date3_visibility")
                        .HasColumnType("bit");

                    b.Property<string>("Descrip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Num1_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Num1_visibility")
                        .HasColumnType("bit");

                    b.Property<string>("Num2_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Num2_visibility")
                        .HasColumnType("bit");

                    b.Property<string>("Num3_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Num3_visibility")
                        .HasColumnType("bit");

                    b.Property<string>("Str1_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Str1_visibility")
                        .HasColumnType("bit");

                    b.Property<string>("Str2_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Str2_visibility")
                        .HasColumnType("bit");

                    b.Property<string>("Str3_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Str3_visibility")
                        .HasColumnType("bit");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("Txt1_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Txt1_visibility")
                        .HasColumnType("bit");

                    b.Property<string>("Txt2_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Txt2_visibility")
                        .HasColumnType("bit");

                    b.Property<string>("Txt3_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Txt3_visibility")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IUserId");

                    b.HasIndex("SubjectId");

                    b.ToTable("CustomCollections");
                });

            modelBuilder.Entity("CourseProject.Models.Entities.CustomItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Check1")
                        .HasColumnType("bit");

                    b.Property<bool>("Check2")
                        .HasColumnType("bit");

                    b.Property<bool>("Check3")
                        .HasColumnType("bit");

                    b.Property<int>("CollectionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date2")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date3")
                        .HasColumnType("datetime2");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Num1")
                        .HasColumnType("int");

                    b.Property<int>("Num2")
                        .HasColumnType("int");

                    b.Property<int>("Num3")
                        .HasColumnType("int");

                    b.Property<string>("Str1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Str2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Str3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Txt1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Txt2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Txt3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.ToTable("CustomItems");
                });

            modelBuilder.Entity("CourseProject.Models.Entities.IUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a9a95ad3-8f11-4bc2-bd0e-1afe2c522532",
                            Email = "admin@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEPT/ZITziPWljXYcwepVooOklPYZ222BctBhlYFSWyT5pL0Oz93tW/wUl/InOmlSYg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("CourseProject.Models.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "7be31283-195b-4d9e-b225-18d39cf80b2b",
                            ConcurrencyStamp = "edd87191-7e9d-4f69-bdd8-c59c88832a42",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                            RoleId = "7be31283-195b-4d9e-b225-18d39cf80b2b"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CourseProject.Models.Entities.Comment", b =>
                {
                    b.HasOne("CourseProject.Models.Entities.CustomItem", null)
                        .WithMany("Comments")
                        .HasForeignKey("CustomItemId");

                    b.HasOne("CourseProject.Models.Entities.IUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CourseProject.Models.Entities.CustomCollection", b =>
                {
                    b.HasOne("CourseProject.Models.Entities.IUser", null)
                        .WithMany("Collections")
                        .HasForeignKey("IUserId");

                    b.HasOne("CourseProject.Models.Entities.Subject", "Subject")
                        .WithMany("CustomCollections")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("CourseProject.Models.Entities.CustomItem", b =>
                {
                    b.HasOne("CourseProject.Models.Entities.CustomCollection", "Collection")
                        .WithMany("Items")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collection");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CourseProject.Models.Entities.IUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CourseProject.Models.Entities.IUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseProject.Models.Entities.IUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CourseProject.Models.Entities.IUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseProject.Models.Entities.CustomCollection", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("CourseProject.Models.Entities.CustomItem", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("CourseProject.Models.Entities.IUser", b =>
                {
                    b.Navigation("Collections");
                });

            modelBuilder.Entity("CourseProject.Models.Entities.Subject", b =>
                {
                    b.Navigation("CustomCollections");
                });
#pragma warning restore 612, 618
        }
    }
}
