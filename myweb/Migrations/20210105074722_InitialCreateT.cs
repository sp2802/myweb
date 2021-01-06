using Microsoft.EntityFrameworkCore.Migrations;

namespace myweb.Migrations
{
    public partial class InitialCreateT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dateCreated",
                table: "Contacts",
                newName: "DateCreated");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Contacts",
                newName: "dateCreated");
        }
    }
}
