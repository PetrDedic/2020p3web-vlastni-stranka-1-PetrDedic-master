using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using P3DedicApp.Models;

namespace P3DedicApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "ADMIN", Name = "Administrátor", NormalizedName = "ADMINISTRÁTOR" });
            var hasher = new PasswordHasher<IdentityUser>();
            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "ADMINUSER",
                Email = "petr.dedic@pslib.cz",
                NormalizedEmail = "PETR.DEDIC@PSLIB.CZ",
                EmailConfirmed = true,
                LockoutEnabled = false,
                UserName = "petr.dedic@pslib.cz",
                NormalizedUserName = "PETR.DEDIC@PSLIB.CZ",
                PasswordHash = hasher.HashPassword(null, "Admin_1234"),
                SecurityStamp = string.Empty
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { RoleId = "ADMIN", UserId = "ADMINUSER" });
            builder.Entity<Song>().HasData(new Song { Id = 1, PlaylistId = 1, Name = "Last Forever", Interpret = "Ayo | Teo", Description = "Singl" });
            builder.Entity<Playlist>().HasData(new Playlist { Id = 1, Name = "Sanchez's liked songs", UserId = "ADMINUSER" });
        }
    }
}
