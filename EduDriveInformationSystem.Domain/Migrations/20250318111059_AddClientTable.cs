using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduDriveInformationSystem.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddClientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientIDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientEmergencyContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "ClientAddress", "ClientCity", "ClientEmailAddress", "ClientEmergencyContact", "ClientFirstName", "ClientGender", "ClientIDNumber", "ClientLastName", "ClientPhoneNumber", "ClientStatus" },
                values: new object[,]
                {
                    { new Guid("2f8fe3e5-ea7e-43be-b9e6-daa9b5d35412"), "456 Oak St, Cape Town, 8001", "Cape Town", "sarah.smith@example.com", "Jane Doe - 0217654321", "Sarah", "Female", "9502028105123", "Smith", "0217654321", 0 },
                    { new Guid("73b6e7f7-c90f-4ecb-bb2c-cf2997712ec7"), "123 Main St, Cape Town, 8000", "Cape Town", "john.doe@example.com", "Jane Doe - 0217654321", "John", "Male", "8501015009087", "Doe", "0211234567", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
