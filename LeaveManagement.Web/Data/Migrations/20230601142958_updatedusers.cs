using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class updatedusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c63c4fc-1178-4816-93d5-ba16426036d9",
                column: "ConcurrencyStamp",
                value: "6bbca9b9-56f7-4996-8b2c-efe19a38b159");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2",
                column: "ConcurrencyStamp",
                value: "26cfb05c-dc02-472b-8888-a30a1ca3c670");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77c0677d-2447-42cb-bc97-8eba952e4468",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d8af8c4e-ff66-4b0f-8a05-ca1afe60060b", "user@localhost.com", "AQAAAAEAACcQAAAAED4bCDUatJ6butLb04FU0A7hirKEdrcWAkxJqMjIIWyiH//uUt+yUW7aScroj4H/FA==", "1692a555-ec0a-4f7f-8240-047508d11661", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c50c87dd-be7b-4618-bb49-fd45040cda92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2c191c0-c009-4408-9a23-7507cc9f6ff0", "AQAAAAEAACcQAAAAEJmpxdQEkv1yQyJtlQVdR/9yDSu13rauxmpMieWh3dLjwKG/np/GfWtF7SfX0w1/dA==", "d24b5b8a-72dd-4579-b8be-b0747fb2e767" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c63c4fc-1178-4816-93d5-ba16426036d9",
                column: "ConcurrencyStamp",
                value: "d089f9cf-08d3-4b05-8933-537cc8e888b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2",
                column: "ConcurrencyStamp",
                value: "3fbc5e28-59a9-4b74-b1e2-02a6bb60c596");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77c0677d-2447-42cb-bc97-8eba952e4468",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d75e957b-2581-4119-84b3-489fb3c63682", "use@localhost.com", "AQAAAAEAACcQAAAAEIT8jcif3HjIzL3fSGDobdaInQaCok4M7Db/iDUVbg4QCz+SfdCH0KcMv3+A4st+4Q==", "2d4ac30f-4050-400d-aa2b-cdcd90213567", "use@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c50c87dd-be7b-4618-bb49-fd45040cda92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7abfd6e-e377-443b-804d-b04d3aff02b5", "AQAAAAEAACcQAAAAEN2atrEmLCrYcfrzYrk8gVdvCr3ZaF3TWbm453fo9JaUXbivtxMLYk4gmEu9E3lc7w==", "30da7560-f474-446f-9cc7-82ad7aebc448" });
        }
    }
}
