using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class updatedleaverequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
