using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_score_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WriterMail",
                table: "Writers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlogScore",
                table: "Comments",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WriterMail",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "BlogScore",
                table: "Comments");
        }
    }
}
