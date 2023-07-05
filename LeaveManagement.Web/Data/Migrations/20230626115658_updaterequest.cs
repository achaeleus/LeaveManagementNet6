using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class updaterequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "Cancelled",
                table: "LeaveRequests",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c63c4fc-1178-4816-93d5-ba16426036d9",
                column: "ConcurrencyStamp",
                value: "ea9d7a78-77b3-495c-83f0-4197cf5efeb5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2",
                column: "ConcurrencyStamp",
                value: "5caf4552-dea9-46aa-b64b-80eb24b19d0e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77c0677d-2447-42cb-bc97-8eba952e4468",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92c5c41c-d0fd-4702-8998-94659847eb72", "AQAAAAEAACcQAAAAEMkqlpjgAU9ITOtsh4Z2PmNGGiiqyJHGYfkCwJ3BWvTz3NrYWQ40nmJCTjHbtRRsfQ==", "1d6f43ed-702e-4976-8a55-3467e96589f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c50c87dd-be7b-4618-bb49-fd45040cda92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e232fdca-b30f-4a88-9b71-9f25678381b0", "AQAAAAEAACcQAAAAELl3T7gzbg3TzJ+GBeYlkrSxaedufu8Z8z1OiOlXHDd2k6wkP0BSedqQaGHf7FvxWQ==", "2846e389-b483-478c-8535-12f8d037b4eb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Cancelled",
                table: "LeaveRequests",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

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
        }
    }
}
