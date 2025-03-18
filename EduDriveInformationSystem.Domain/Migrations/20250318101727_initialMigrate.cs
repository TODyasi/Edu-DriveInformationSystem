using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduDriveInformationSystem.Domain.Migrations
{
    /// <inheritdoc />
    public partial class initialMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
