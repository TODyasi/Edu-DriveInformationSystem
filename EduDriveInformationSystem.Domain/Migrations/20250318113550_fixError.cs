using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduDriveInformationSystem.Domain.Migrations
{
    /// <inheritdoc />
    public partial class fixError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "drivingLessons",
                keyColumn: "LessonId",
                keyValue: 12345,
                column: "LessonDate",
                value: new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "drivingLessons",
                keyColumn: "LessonId",
                keyValue: 12345,
                column: "LessonDate",
                value: new DateTime(2025, 3, 19, 11, 34, 31, 327, DateTimeKind.Local).AddTicks(5606));
        }
    }
}
