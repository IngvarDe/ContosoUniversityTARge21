using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class FirstMidName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Department_DepartmentId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseAssignment_Course_CourseId",
                table: "CourseAssignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "CourseAssignment",
                newName: "CourseID");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Course",
                newName: "CourseID");

            migrationBuilder.AddColumn<string>(
                name: "FirstMidName",
                table: "Instructor",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Department",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Department_DepartmentId",
                table: "Course",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAssignment_Course_CourseID",
                table: "CourseAssignment",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Department_DepartmentId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseAssignment_Course_CourseID",
                table: "CourseAssignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "FirstMidName",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "CourseAssignment",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Course",
                newName: "CourseId");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Instructor",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Department_DepartmentId",
                table: "Course",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAssignment_Course_CourseId",
                table: "CourseAssignment",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
