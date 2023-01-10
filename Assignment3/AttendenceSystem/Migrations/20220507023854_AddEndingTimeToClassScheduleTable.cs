using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AttendenceSystem.Migrations
{
    public partial class AddEndingTimeToClassScheduleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "ClassSchedules",
                newName: "StartingTime");

            migrationBuilder.AddColumn<string>(
                name: "EndingTime",
                table: "ClassSchedules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndingTime",
                table: "ClassSchedules");

            migrationBuilder.RenameColumn(
                name: "StartingTime",
                table: "ClassSchedules",
                newName: "Time");
        }
    }
}
