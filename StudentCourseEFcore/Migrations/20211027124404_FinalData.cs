using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentCourseEFcore.Migrations
{
    public partial class FinalData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseCode", "Name", "StudentId" },
                values: new object[,]
                {
                    { 1, "Bio 101", "Life Biology", 1 },
                    { 15, "Chem 101", "Physical Chemistry", 3 },
                    { 14, "Eng 101", "English", 3 },
                    { 13, "BioTech 101", "Biotechnology", 3 },
                    { 12, "Phy 101", "Modern Physics", 3 },
                    { 11, "Bio 101", "Life Biology", 3 },
                    { 10, "Chem 101", "Physical Chemistry", 2 },
                    { 9, "Eng 101", "English", 2 },
                    { 7, "Phy 101", "Modern Physics", 2 },
                    { 6, "Bio 101", "Life Biology", 2 },
                    { 5, "Chem 101", "Physical Chemistry", 1 },
                    { 4, "Eng 101", "English", 1 },
                    { 3, "BioTech 101", "Biotechnology", 1 },
                    { 2, "Phy 101", "Modern Physics", 1 },
                    { 8, "BioTech 101", "Biotechnology", 2 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Department", "FirstName", "LastName", "RegNo" },
                values: new object[,]
                {
                    { 2, "Zoology", "Jikki", "Agu", "2011/235354" },
                    { 1, "Botany", "Chikki", "Dike", "2010/145354" },
                    { 3, "Animal sci", "Ego", "Uzoh", "2014/145355" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);
        }
    }
}
