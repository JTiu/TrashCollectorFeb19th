using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorFeb19th.Data.Migrations
{
    public partial class AdditionalCustomerInput : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "100f31bf-8402-4234-b57e-8acde3a25aaa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8426b8a3-21d5-4168-8b65-c55d2a60a69c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0d352a7-18e3-4d64-8d88-5f80ac8adcea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd48df2d-e3c3-4e73-8ad0-bcd0542174d4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "88091e65-e3ba-401d-849a-41d25ae0a646", "57e0b29a-b459-4b38-804a-72185d5908d9", "Admin", "ADMIN" },
                    { "fa99bbb8-be07-4920-ac87-629f89d2dfbe", "318cbc74-e93e-4f14-afa1-7d89757f9784", "Customer", "CUSTOMER" },
                    { "c2c0f050-a43e-4422-bfec-45f2d3631eea", "c0ec4863-b254-4820-a4c4-513de27bfdd0", "Employee", "EMPLOYEE" },
                    { "108a222f-fce0-414d-9706-0010007619c9", "6f366c9b-0762-4572-885e-2b205aee6e01", "Organic Compost Advocate", "ORG COMP ADV" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "108a222f-fce0-414d-9706-0010007619c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88091e65-e3ba-401d-849a-41d25ae0a646");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2c0f050-a43e-4422-bfec-45f2d3631eea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa99bbb8-be07-4920-ac87-629f89d2dfbe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8426b8a3-21d5-4168-8b65-c55d2a60a69c", "54797a87-e0d6-4ea6-839d-c8738a658150", "Admin", "ADMIN" },
                    { "f0d352a7-18e3-4d64-8d88-5f80ac8adcea", "7ebf819c-4429-4e88-93d2-fb883fb714fe", "Customer", "CUSTOMER" },
                    { "fd48df2d-e3c3-4e73-8ad0-bcd0542174d4", "9fb0757d-a8dc-4f18-9df3-df32a5f50d43", "Employee", "EMPLOYEE" },
                    { "100f31bf-8402-4234-b57e-8acde3a25aaa", "86f10819-94d7-49a6-9787-5f3ae9bb436d", "Organic Compost Advocate", "ORG COMP ADV" }
                });
        }
    }
}
