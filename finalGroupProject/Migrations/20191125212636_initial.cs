using Microsoft.EntityFrameworkCore.Migrations;

namespace finalGroupProject.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarSupply",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fName = table.Column<string>(maxLength: 25, nullable: false),
                    lName = table.Column<string>(maxLength: 25, nullable: false),
                    address = table.Column<string>(maxLength: 75, nullable: false),
                    city = table.Column<string>(maxLength: 20, nullable: false),
                    state = table.Column<string>(maxLength: 2, nullable: false),
                    zip = table.Column<string>(maxLength: 10, nullable: false),
                    phone = table.Column<string>(maxLength: 12, nullable: false),
                    userName = table.Column<string>(maxLength: 20, nullable: false),
                    password = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarSupply", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarSupply");
        }
    }
}
