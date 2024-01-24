using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoneyNote.Migrations
{
    public partial class UpdateNvarcharNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Transaction",
                type: "nvarchar(80)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Transaction",
                type: "nvarchar(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldNullable: true);
        }
    }
}
