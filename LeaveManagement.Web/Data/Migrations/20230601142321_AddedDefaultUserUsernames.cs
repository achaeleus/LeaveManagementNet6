using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d75e957b-2581-4119-84b3-489fb3c63682", true, "User@LOCALHOST.COM", "AQAAAAEAACcQAAAAEIT8jcif3HjIzL3fSGDobdaInQaCok4M7Db/iDUVbg4QCz+SfdCH0KcMv3+A4st+4Q==", "2d4ac30f-4050-400d-aa2b-cdcd90213567", "use@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c50c87dd-be7b-4618-bb49-fd45040cda92",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b7abfd6e-e377-443b-804d-b04d3aff02b5", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEN2atrEmLCrYcfrzYrk8gVdvCr3ZaF3TWbm453fo9JaUXbivtxMLYk4gmEu9E3lc7w==", "30da7560-f474-446f-9cc7-82ad7aebc448", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c63c4fc-1178-4816-93d5-ba16426036d9",
                column: "ConcurrencyStamp",
                value: "96fbdb62-98dc-45b3-b843-0b0866a18e8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2",
                column: "ConcurrencyStamp",
                value: "5b6a453e-9f22-4f5c-8ad6-2fe39bf549d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77c0677d-2447-42cb-bc97-8eba952e4468",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bb85cea0-3040-4052-ae62-9590b9d1ec3e", false, null, "AQAAAAEAACcQAAAAEHuuAyKRJb/aFkr7h4FKrqZOmNoBbh4OfLPba4Km+FITmF8CF3NGatArLCKnutd0jA==", "321b1209-1d8e-4f66-bc5f-a67bdfdecb51", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c50c87dd-be7b-4618-bb49-fd45040cda92",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2c5dfd63-614e-4e2b-90a7-cdfa25ec7df1", false, null, "AQAAAAEAACcQAAAAEExtIZTKjtFm5qAlG0OgBkV6wx7cnfPdajcPFEC2KZYYAqhlYcdAD+A1v1wmA4xE5Q==", "08515086-421b-43b9-9e0e-abe14e958c41", null });
        }
    }
}
