using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class blogRayting2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlogRaytingCunt",
                table: "BlogRaytings",
                newName: "BlogRaytingCount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlogRaytingCount",
                table: "BlogRaytings",
                newName: "BlogRaytingCunt");
        }
    }
}
