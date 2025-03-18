using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduDriveInformationSystem.Domain.Migrations
{
    /// <inheritdoc />
    public partial class FixStaticValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("3c718c17-c474-46b1-afc5-ca03efe38c65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("459465e1-2d54-4161-a0c1-ed15481264ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("c879cdfc-dbfe-451d-bb48-1b500cc99ff8"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserContactNumber", "UserEmail", "UserFirstName", "UserLastName", "UserPassword", "UserRole" },
                values: new object[,]
                {
                    { new Guid("23301fc1-ef6e-467f-92fe-16301953a784"), "+27 987 654 321", "instructor@drivingschool.com", "Jane", "Smith", "hashedPasswordHere", 2 },
                    { new Guid("7eaef12d-b8d9-473b-8309-2f4b8c44fae4"), "+27 555 123 456", "sales@drivingschool.com", "Sarah", "Johnson", "hashedPasswordHere", 1 },
                    { new Guid("f0a1b207-763c-4e4a-a12b-d76d41dce45f"), "+27 123 456 789", "admin@drivingschool.com", "John", "Doe", "hashedPasswordHere", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("23301fc1-ef6e-467f-92fe-16301953a784"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("7eaef12d-b8d9-473b-8309-2f4b8c44fae4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f0a1b207-763c-4e4a-a12b-d76d41dce45f"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "UserContactNumber", "UserEmail", "UserFirstName", "UserLastName", "UserPassword", "UserRole" },
                values: new object[,]
                {
                    { new Guid("3c718c17-c474-46b1-afc5-ca03efe38c65"), "+27 987 654 321", "instructor@drivingschool.com", "Jane", "Smith", "hashedPasswordHere", 2 },
                    { new Guid("459465e1-2d54-4161-a0c1-ed15481264ed"), "+27 123 456 789", "admin@drivingschool.com", "John", "Doe", "hashedPasswordHere", 0 },
                    { new Guid("c879cdfc-dbfe-451d-bb48-1b500cc99ff8"), "+27 555 123 456", "sales@drivingschool.com", "Sarah", "Johnson", "hashedPasswordHere", 1 }
                });
        }
    }
}
