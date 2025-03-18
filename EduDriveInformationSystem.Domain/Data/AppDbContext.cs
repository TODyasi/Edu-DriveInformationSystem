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
            var adminUserId = Guid.Parse("f0a1b207-763c-4e4a-a12b-d76d41dce45f");
            var instructorUserId = Guid.Parse("23301fc1-ef6e-467f-92fe-16301953a784");
            var salesAgentUserId = Guid.Parse("7eaef12d-b8d9-473b-8309-2f4b8c44fae4");

            modelBuilder.Entity<UserModel>().HasData(
            new UserModel
            {
                UserId = adminUserId,
                UserFirstName = "John",
                UserLastName = "Doe",
                UserEmail = "admin@drivingschool.com",
                UserContactNumber = "+27 123 456 789",
                UserPassword = "hashedPasswordHere", 
                UserRole = UserRoles.Admin
            },
            new UserModel
            {
                UserId = instructorUserId,
                UserFirstName = "Jane",
                UserLastName = "Smith",
                UserEmail = "instructor@drivingschool.com",
                UserContactNumber = "+27 987 654 321",
                UserPassword = "hashedPasswordHere",
                UserRole = UserRoles.Instructor
            },
            new UserModel
            {
                UserId = salesAgentUserId,
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
