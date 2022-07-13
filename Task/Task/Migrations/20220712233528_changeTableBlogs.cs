using Microsoft.EntityFrameworkCore.Migrations;

namespace Task.Migrations
{
    public partial class changeTableBlogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Blogs");
        }
    }
}
