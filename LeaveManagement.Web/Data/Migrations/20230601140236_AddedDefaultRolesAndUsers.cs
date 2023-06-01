using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultRolesAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c63c4fc-1178-4816-93d5-ba16426036d9", "96fbdb62-98dc-45b3-b843-0b0866a18e8e", "Administrator", "ADMINISTRATOR" },
                    { "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2", "5b6a453e-9f22-4f5c-8ad6-2fe39bf549d3", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "77c0677d-2447-42cb-bc97-8eba952e4468", 0, "bb85cea0-3040-4052-ae62-9590b9d1ec3e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "use@localhost.com", false, "System", "User", false, null, "User@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEHuuAyKRJb/aFkr7h4FKrqZOmNoBbh4OfLPba4Km+FITmF8CF3NGatArLCKnutd0jA==", null, false, "321b1209-1d8e-4f66-bc5f-a67bdfdecb51", null, false, null },
                    { "c50c87dd-be7b-4618-bb49-fd45040cda92", 0, "2c5dfd63-614e-4e2b-90a7-cdfa25ec7df1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEExtIZTKjtFm5qAlG0OgBkV6wx7cnfPdajcPFEC2KZYYAqhlYcdAD+A1v1wmA4xE5Q==", null, false, "08515086-421b-43b9-9e0e-abe14e958c41", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2", "77c0677d-2447-42cb-bc97-8eba952e4468" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0c63c4fc-1178-4816-93d5-ba16426036d9", "c50c87dd-be7b-4618-bb49-fd45040cda92" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2", "7c0677d-2447-42cb-bc97-8eba952e4468" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c63c4fc-1178-4816-93d5-ba16426036d9", "c50c87dd-be7b-4618-bb49-fd45040cda92" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77c0677d-2447-42cb-bc97-8eba952e4468");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c63c4fc-1178-4816-93d5-ba16426036d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c50c87dd-be7b-4618-bb49-fd45040cda92");
        }
    }
}
