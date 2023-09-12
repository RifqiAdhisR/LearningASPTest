using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLearningTest.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserApp",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Pace = table.Column<int>(type: "int", nullable: true),
                    Milage = table.Column<int>(type: "int", nullable: true),
                    Addressid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserApp", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserApp_Addresses_Addressid",
                        column: x => x.Addressid,
                        principalTable: "Addresses",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    ClubCategory = table.Column<int>(type: "int", nullable: false),
                    UserAppId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clubs_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clubs_UserApp_UserAppId",
                        column: x => x.UserAppId,
                        principalTable: "UserApp",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    RaceCategory = table.Column<int>(type: "int", nullable: false),
                    UserAppId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Races_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Races_UserApp_UserAppId",
                        column: x => x.UserAppId,
                        principalTable: "UserApp",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_AddressId",
                table: "Clubs",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_UserAppId",
                table: "Clubs",
                column: "UserAppId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_AddressId",
                table: "Races",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_UserAppId",
                table: "Races",
                column: "UserAppId");

            migrationBuilder.CreateIndex(
                name: "IX_UserApp_Addressid",
                table: "UserApp",
                column: "Addressid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "UserApp");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
