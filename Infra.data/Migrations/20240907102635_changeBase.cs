using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.data.Migrations
{
    /// <inheritdoc />
    public partial class changeBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Update_date",
                table: "Users",
                newName: "Updated_At");

            migrationBuilder.RenameColumn(
                name: "Creation_date",
                table: "Users",
                newName: "Created_At");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Updated_At",
                table: "Users",
                newName: "Update_date");

            migrationBuilder.RenameColumn(
                name: "Created_At",
                table: "Users",
                newName: "Creation_date");
        }
    }
}
