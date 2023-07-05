using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class updateleaverequesttwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "cea44d3b-c38b-4a5b-ab5e-1795c24f548e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe3f500d-ebf3-4fea-bc04-2a82cbab12b2",
                column: "ConcurrencyStamp",
                value: "8835ea24-c6f3-4356-8c47-58418fe0b8a5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77c0677d-2447-42cb-bc97-8eba952e4468",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75dc729e-aeec-4c06-9dc5-8684b4690970", "AQAAAAEAACcQAAAAEOLBMWeUloSNG6/dcy6VgzNVa5itUtvCbqLEa4YJ0XYUB+56iHT6DS+3i78alSndbw==", "33d0153d-c27b-44bd-b5f2-f0c24967839f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c50c87dd-be7b-4618-bb49-fd45040cda92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "003776ac-0089-4939-b3f5-379d43389056", "AQAAAAEAACcQAAAAEM8Bgh7O8+R2l1rymfR3lBuRcvH7eG3086nwNKclJpLBqRzpIbQ+OFsxyGpaGTIA1w==", "c45af432-595c-48fc-97d9-cd064b8d4be7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
