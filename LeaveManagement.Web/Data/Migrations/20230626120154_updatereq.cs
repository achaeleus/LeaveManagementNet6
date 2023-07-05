using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class updatereq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                value: "6a398133-d7ef-4e9d-b74a-8fd8e50cd79c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2",
                column: "ConcurrencyStamp",
                value: "9bd22f1a-2bb2-489d-a035-f9244241f435");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77c0677d-2447-42cb-bc97-8eba952e4468",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "034b2162-492d-4773-a185-79da60d40d86", "AQAAAAEAACcQAAAAEI4OnS6/hNvwKA7BVlDyEZwed0gsyivNRBN402+v7SCmkONnXu+NvW5zR6bPalxmBg==", "ebb1f0a9-5844-406b-9254-9ea6178463fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c50c87dd-be7b-4618-bb49-fd45040cda92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b1adac7-6773-4548-a890-b466db1c103a", "AQAAAAEAACcQAAAAEAG6f7x6FJZrATvbwNTWxuvqds5WmsZBECiWdg66rwzINMoTqD4G5kJrG1d8HUd+3g==", "3a7fa97d-52b5-4384-8fda-17c8c8c83b73" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                value: "987d65e8-f02e-41dd-bff0-cf78a229aa62");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2",
                column: "ConcurrencyStamp",
                value: "709ea53f-32ad-4954-8a3e-bd008e8aa02b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77c0677d-2447-42cb-bc97-8eba952e4468",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70b61393-132b-4c5f-bf20-bc77ca90601c", "AQAAAAEAACcQAAAAEOltaQ4KWZlNozQgSZDEVgafKgyOYcqUpMec1QYRGIS/4V1baePVijRUZ0Q7sMPsag==", "b6ee0d71-fec2-4f11-947f-c60f275e12f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c50c87dd-be7b-4618-bb49-fd45040cda92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46749919-d67c-4635-b6f8-2753ba75bd41", "AQAAAAEAACcQAAAAEGgz41/JUAztv4pDCBHnof9h6XZSYxk6DoQRkUC2uTo4vP1RMeDoxO+LJXJ9HGIwdw==", "2cc54102-43a4-4014-bc41-937ae9c10af9" });
        }
    }
}
