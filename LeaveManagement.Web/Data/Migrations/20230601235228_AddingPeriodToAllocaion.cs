using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocaion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8af8c4e-ff66-4b0f-8a05-ca1afe60060b", "AQAAAAEAACcQAAAAED4bCDUatJ6butLb04FU0A7hirKEdrcWAkxJqMjIIWyiH//uUt+yUW7aScroj4H/FA==", "1692a555-ec0a-4f7f-8240-047508d11661" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c50c87dd-be7b-4618-bb49-fd45040cda92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2c191c0-c009-4408-9a23-7507cc9f6ff0", "AQAAAAEAACcQAAAAEJmpxdQEkv1yQyJtlQVdR/9yDSu13rauxmpMieWh3dLjwKG/np/GfWtF7SfX0w1/dA==", "d24b5b8a-72dd-4579-b8be-b0747fb2e767" });
        }
    }
}
