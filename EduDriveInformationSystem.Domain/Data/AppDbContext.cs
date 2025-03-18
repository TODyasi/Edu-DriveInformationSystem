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
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<DrivingLessonModel> drivingLessons { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
            base.OnModelCreating(modelBuilder);
            var adminUserId = Guid.Parse("f0a1b207-763c-4e4a-a12b-d76d41dce45f");
            var instructorUserId = Guid.Parse("23301fc1-ef6e-467f-92fe-16301953a784");
            var salesAgentUserId = Guid.Parse("7eaef12d-b8d9-473b-8309-2f4b8c44fae4");

            var michaelClientId = Guid.Parse("2f8fe3e5-ea7e-43be-b9e6-daa9b5d35412");
            var lisaClientId = Guid.Parse("73b6e7f7-c90f-4ecb-bb2c-cf2997712ec7");
            var lessonId = Guid.Parse("cdd57b8e-6743-4003-bf42-b5735be09735");
            var paymentId = Guid.Parse("32006307-b445-472a-87a4-7d14f2ae387d");


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

            modelBuilder.Entity<ClientModel>().HasData(
               new ClientModel
               {
                   ClientId = lisaClientId,
                   ClientFirstName = "John",
                   ClientLastName = "Doe",
                   ClientGender = "Male",
                   ClientIDNumber = "8501015009087",
                   ClientAddress = "123 Main St, Cape Town, 8000",
                   ClientCity = "Cape Town",
                   ClientEmailAddress = "john.doe@example.com",
                   ClientPhoneNumber = "0211234567",
                   ClientEmergencyContact = "Jane Doe - 0217654321",
                   ClientStatus = 0
               },
               new ClientModel
               {
                   ClientId = michaelClientId,
                   ClientFirstName = "Sarah",
                   ClientLastName = "Smith",
                   ClientGender = "Female",
                   ClientIDNumber = "9502028105123",
                   ClientAddress = "456 Oak St, Cape Town, 8001",
                   ClientCity = "Cape Town",
                   ClientEmailAddress = "sarah.smith@example.com",
                   ClientPhoneNumber = "0217654321",
                   ClientEmergencyContact = "Jane Doe - 0217654321",
                   ClientStatus = 0
               }

           );
            modelBuilder.Entity<DrivingLessonModel>().HasData(
               new DrivingLessonModel
               {
                   LessonId = 12345,
                   LessonDate = new DateTime(2025, 3, 20),
                   LessonDuration = TimeSpan.FromHours(1),
                   LessonType = "Driving",
                   LessonNotes = "Initial lesson. Focus on basic control.",
                   LessonStatus = "Pending",
               },
               new DrivingLessonModel
               {
                   LessonId = 7464657,  // Use the GUID of an existing client Use the GUID of an existing instructor
                   LessonDate = new DateTime(2025, 3, 20),
                   LessonDuration = TimeSpan.FromHours(1),
                   LessonType = "Driving",
                   LessonNotes = "Intermediate lesson. Practice parking.",
                   LessonStatus = "Pending"
               }
           );
        }
    }
}
