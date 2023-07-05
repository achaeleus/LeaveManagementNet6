using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: true),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c63c4fc-1178-4816-93d5-ba16426036d9",
                column: "ConcurrencyStamp",
                value: "5dd3c6d1-3c2e-489d-ba50-c449831a6ce5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2",
                column: "ConcurrencyStamp",
                value: "3cf01aca-c7c9-4ce8-bd7e-986b110fab9c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77c0677d-2447-42cb-bc97-8eba952e4468",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5df29052-1910-4bd6-b14a-dc888a185022", "AQAAAAEAACcQAAAAEDdi62W17HvO5Cje5tuWiR7TJrJ7g+ljJO787AQrBOHNH3nR9wXWI18G0AjCEDKszQ==", "f217d103-3dc5-4391-91fe-054e1c987d21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c50c87dd-be7b-4618-bb49-fd45040cda92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "627a15a8-a42b-4731-b7ac-03f3ff7b3c2b", "AQAAAAEAACcQAAAAEJWENDyy3PVGxx1cRhSPEkCDmfBz/2jDiU2iz8apyuEn15HO/JFbPe87XC7I3+E+SQ==", "921a4011-ccbc-4883-b83b-dafe71420553" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c63c4fc-1178-4816-93d5-ba16426036d9",
                column: "ConcurrencyStamp",
                value: "58ef396e-2a42-4c25-90af-f457ee9c4b85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2",
                column: "ConcurrencyStamp",
                value: "e92d657e-2b8f-4d5e-b3aa-ae94948cacfc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77c0677d-2447-42cb-bc97-8eba952e4468",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38acb825-9afd-496c-8fbf-58c802e5a573", "AQAAAAEAACcQAAAAEMqB+gixmH9WX+1B7LhBL3DtkSU+uHPCS7yZbMKd0xDa93UBEiU69UVIneRvi4XWXQ==", "23761f8b-d4ff-4037-b906-924000cdf5c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c50c87dd-be7b-4618-bb49-fd45040cda92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fec16657-1823-49a3-82ce-2b27a21f0286", "AQAAAAEAACcQAAAAEOniAyXi4VfJCFrmSam05TyCSgXoHS/XpGz3mcDl/ZpiBHfBdNSv/1+tQKMb94Y6Mg==", "dd31653a-5386-4223-a9e7-92211d52b69b" });
        }
    }
}
