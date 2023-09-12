using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLearningTest.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Races_UserApp_UserAppId",
                table: "Races");

            migrationBuilder.DropForeignKey(
                name: "FK_UserApp_Addresses_Addressid",
                table: "UserApp");

            migrationBuilder.RenameColumn(
                name: "Addressid",
                table: "UserApp",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_UserApp_Addressid",
                table: "UserApp",
                newName: "IX_UserApp_AddressId");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "Addresses",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Addresses",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Addresses",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Addresses",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "UserAppId",
                table: "Races",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Races_UserApp_UserAppId",
                table: "Races",
                column: "UserAppId",
                principalTable: "UserApp",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserApp_Addresses_AddressId",
                table: "UserApp",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Races_UserApp_UserAppId",
                table: "Races");

            migrationBuilder.DropForeignKey(
                name: "FK_UserApp_Addresses_AddressId",
                table: "UserApp");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "UserApp",
                newName: "Addressid");

            migrationBuilder.RenameIndex(
                name: "IX_UserApp_AddressId",
                table: "UserApp",
                newName: "IX_UserApp_Addressid");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Addresses",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Addresses",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Addresses",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Addresses",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "UserAppId",
                table: "Races",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_UserApp_UserAppId",
                table: "Races",
                column: "UserAppId",
                principalTable: "UserApp",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserApp_Addresses_Addressid",
                table: "UserApp",
                column: "Addressid",
                principalTable: "Addresses",
                principalColumn: "id");
        }
    }
}
