using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Padeanu_Andreea_Lab2.Migrations
{
    public partial class Authors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "book");

            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PublisherID",
                table: "book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_book_AuthorID",
                table: "book",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_book_PublisherID",
                table: "book",
                column: "PublisherID");

            migrationBuilder.AddForeignKey(
                name: "FK_book_Authors_AuthorID",
                table: "book",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_Publisher_PublisherID",
                table: "book",
                column: "PublisherID",
                principalTable: "Publisher",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_Authors_AuthorID",
                table: "book");

            migrationBuilder.DropForeignKey(
                name: "FK_book_Publisher_PublisherID",
                table: "book");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropIndex(
                name: "IX_book_AuthorID",
                table: "book");

            migrationBuilder.DropIndex(
                name: "IX_book_PublisherID",
                table: "book");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "book");

            migrationBuilder.DropColumn(
                name: "PublisherID",
                table: "book");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
