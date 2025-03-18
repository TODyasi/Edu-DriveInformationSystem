using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduDriveInformationSystem.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddLessonTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "drivingLessons",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LessonDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LessonDuration = table.Column<TimeSpan>(type: "time", nullable: false),
                    LessonType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drivingLessons", x => x.LessonId);
                });

            migrationBuilder.InsertData(
                table: "drivingLessons",
                columns: new[] { "LessonId", "InstructorId", "LessonDate", "LessonDuration", "LessonNotes", "LessonStatus", "LessonType" },
                values: new object[,]
                {
                    { 12345, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 3, 19, 11, 34, 31, 327, DateTimeKind.Local).AddTicks(5606), new TimeSpan(0, 1, 0, 0, 0), "Initial lesson. Focus on basic control.", "Pending", "Driving" },
                    { 7464657, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), "Intermediate lesson. Practice parking.", "Pending", "Driving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "drivingLessons");
        }
    }
}
