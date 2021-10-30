using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentCourseEFcore.Migrations
{
    public partial class AddedCourseName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Courses",
                newName: "CourseName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseName",
                table: "Courses",
                newName: "Name");
        }
    }
}
