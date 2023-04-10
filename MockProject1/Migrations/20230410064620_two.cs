using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MockProject1.Migrations
{
    /// <inheritdoc />
    public partial class two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Hobbys_HobbiesName",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "HobbiesName",
                table: "Students",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Hobbys_HobbiesName",
                table: "Students",
                column: "HobbiesName",
                principalTable: "Hobbys",
                principalColumn: "HobbyName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Hobbys_HobbiesName",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "HobbiesName",
                table: "Students",
                type: "nvarchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Hobbys_HobbiesName",
                table: "Students",
                column: "HobbiesName",
                principalTable: "Hobbys",
                principalColumn: "HobbyName",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
