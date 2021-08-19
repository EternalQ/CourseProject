using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<CustomItem> CustomItems { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<CustomCollection> CustomCollections { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "7be31283-195b-4d9e-b225-18d39cf80b2b",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<User>().HasData(new User
            {
                Id = "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "admin"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = "2de16b1e-6429-4b9d-a8a4-5e8c2af23fc7",
                RoleId = "7be31283-195b-4d9e-b225-18d39cf80b2b"
            });
        }
    }
}
