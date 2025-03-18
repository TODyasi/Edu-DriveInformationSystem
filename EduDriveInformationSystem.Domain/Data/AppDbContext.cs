using System.Collections.Generic;
using System.Net.Sockets;
using EduDriveInformationSystem.Domain.Models.Entities;
using EduDriveInformationSystem.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace EduDriveInformationSystem.Domain.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Define the DbSets for CRM Entities
        public DbSet<UserModel> Users { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserModel>().HasData(
            new UserModel
            {
                UserId = Guid.NewGuid(),
                UserFirstName = "John",
                UserLastName = "Doe",
                UserEmail = "admin@drivingschool.com",
                UserContactNumber = "+27 123 456 789",
                UserPassword = "hashedPasswordHere", // Replace with actual hashed password
                UserRole = UserRoles.Admin
            },
            new UserModel
            {
                UserId = Guid.NewGuid(),
                UserFirstName = "Jane",
                UserLastName = "Smith",
                UserEmail = "instructor@drivingschool.com",
                UserContactNumber = "+27 987 654 321",
                UserPassword = "hashedPasswordHere", // Replace with actual hashed password
                UserRole = UserRoles.Instructor
            },
            new UserModel
            {
                UserId = Guid.NewGuid(),
                UserFirstName = "Sarah",
                UserLastName = "Johnson",
                UserEmail = "sales@drivingschool.com",
                UserContactNumber = "+27 555 123 456",
                UserPassword = "hashedPasswordHere", // Replace with actual hashed password
                UserRole = UserRoles.SalesAgent
            });
        }
    }
}
