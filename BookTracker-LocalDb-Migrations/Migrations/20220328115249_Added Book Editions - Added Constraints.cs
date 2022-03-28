using Microsoft.EntityFrameworkCore.Migrations;

namespace BookTracker_LocalDb_Migrations.Migrations
{
    public partial class AddedBookEditionsAddedConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookEdition_Books_BookId",
                table: "BookEdition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookEdition",
                table: "BookEdition");

            migrationBuilder.RenameTable(
                name: "BookEdition",
                newName: "Editions");

            migrationBuilder.RenameIndex(
                name: "IX_BookEdition_BookId",
                table: "Editions",
                newName: "IX_Editions_BookId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Editions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Editions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Editions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Editions",
                table: "Editions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Editions_Books_BookId",
                table: "Editions",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Editions_Books_BookId",
                table: "Editions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Editions",
                table: "Editions");

            migrationBuilder.RenameTable(
                name: "Editions",
                newName: "BookEdition");

            migrationBuilder.RenameIndex(
                name: "IX_Editions_BookId",
                table: "BookEdition",
                newName: "IX_BookEdition_BookId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "BookEdition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "BookEdition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "BookEdition",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookEdition",
                table: "BookEdition",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookEdition_Books_BookId",
                table: "BookEdition",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
