using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainigCenterApi.Migrations
{
    /// <inheritdoc />
    public partial class removeColinCoure_addColumn_in_courseVedio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfLectures",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "PeriodVedioMinutes",
                table: "CourseVideos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeriodVedioMinutes",
                table: "CourseVideos");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfLectures",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
