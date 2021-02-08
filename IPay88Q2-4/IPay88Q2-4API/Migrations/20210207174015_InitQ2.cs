using Microsoft.EntityFrameworkCore.Migrations;

namespace IPay88Q2_4API.Migrations
{
    public partial class InitQ2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Friend",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyID = table.Column<int>(nullable: false),
                    FriendsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friend", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Friend_Student_FriendsID",
                        column: x => x.FriendsID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Friend_Student_MyID",
                        column: x => x.MyID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyID = table.Column<int>(nullable: false),
                    Salary = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Packages_Student_MyID",
                        column: x => x.MyID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friend_FriendsID",
                table: "Friend",
                column: "FriendsID");

            migrationBuilder.CreateIndex(
                name: "IX_Friend_MyID",
                table: "Friend",
                column: "MyID");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_MyID",
                table: "Packages",
                column: "MyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friend");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
