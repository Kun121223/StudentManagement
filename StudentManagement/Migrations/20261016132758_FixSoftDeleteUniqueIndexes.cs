using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagement.Migrations
{
    /// <inheritdoc />
    public partial class FixSoftDeleteUniqueIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UQ_Students_Email",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "UQ_Students_StudentNumber",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "UQ_Students_Email",
                table: "Students",
                column: "Email",
                unique: true,
                filter: "[IsActive] = 1");

            migrationBuilder.CreateIndex(
                name: "UQ_Students_StudentNumber",
                table: "Students",
                column: "StudentNumber",
                unique: true,
                filter: "[IsActive] = 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UQ_Students_Email",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "UQ_Students_StudentNumber",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "UQ_Students_Email",
                table: "Students",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_Students_StudentNumber",
                table: "Students",
                column: "StudentNumber",
                unique: true);
        }
    }
}
