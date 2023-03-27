using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectSystem.Migrations
{
    /// <inheritdoc />
    public partial class addIndexProductCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_productCategories_Name",
                table: "productCategories",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_productCategories_Name",
                table: "productCategories");
        }
    }
}
