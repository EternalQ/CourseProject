using CourseProject.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class AppDbContext : IdentityDbContext<IUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<CustomItem> CustomItems { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<CustomCollection> CustomCollections { get; set; }
        public DbSet<ItemLikes> ItemLikes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "7be31283-195b-4d9e-b225-18d39cf80b2b",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IUser>().HasData(new IUser
            {
                Id = "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IUser>().HashPassword(null, "admin"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                RoleId = "7be31283-195b-4d9e-b225-18d39cf80b2b"
            });

            builder.Entity<Subject>().HasData(new Subject
            {
                Id = "50b3ca6b-f3fb-417a-8814-a21d3b2ed44a",
                Name = "Books"
            }, new Subject
            {
                Id = "bb00ad70-c777-450e-a691-4879ca3dd265",
                Name = "Watches"
            }, new Subject
            {
                Id="6797d70b-1ab6-4124-80de-f58ed1de95be",
                Name = "Flora"
            }, new Subject
            {
                Id="6028d62e-58ec-4d74-a2bf-732992497307",
                Name = "Fauna"
            }, new Subject
            {
                Id = "94e6c7e6-a59c-4589-bd27-f88c6c94831a",
                Name = "Custom"
            });

            builder.Entity<CustomCollection>().Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Entity<CustomItem>().Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Entity<ItemLikes>().Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Entity<Comment>().Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Entity<Subject>().Property(c => c.Id).ValueGeneratedOnAdd();
        }
    }
}
