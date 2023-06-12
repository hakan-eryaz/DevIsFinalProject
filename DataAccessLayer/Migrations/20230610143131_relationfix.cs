using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class relationfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_JobCategories_JobCategoryCategoryID",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_JobCategoryCategoryID",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "JobCategoryCategoryID",
                table: "Jobs");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CategoryID",
                table: "Jobs",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_JobCategories_CategoryID",
                table: "Jobs",
                column: "CategoryID",
                principalTable: "JobCategories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_JobCategories_CategoryID",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_CategoryID",
                table: "Jobs");

            migrationBuilder.AddColumn<int>(
                name: "JobCategoryCategoryID",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_JobCategoryCategoryID",
                table: "Jobs",
                column: "JobCategoryCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_JobCategories_JobCategoryCategoryID",
                table: "Jobs",
                column: "JobCategoryCategoryID",
                principalTable: "JobCategories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
