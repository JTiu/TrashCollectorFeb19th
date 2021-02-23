using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorFeb19th.Data.Migrations
{
    public partial class IdentityUser_Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d2eaa70-5ba1-4a1a-bff0-4a4af145af47");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45c3da44-951a-4a95-8fc9-8ae9ede41e50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcc69c90-40a0-490f-bdc3-8f49fcdabbfa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edd280f2-8760-4a4a-bc4f-4d6a2ec324dc");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "bcc69c90-40a0-490f-bdc3-8f49fcdabbfa", "1c13cff2-e186-482e-8d8b-3f26872567ba", "Admin", "ADMIN" },
                    { "3d2eaa70-5ba1-4a1a-bff0-4a4af145af47", "2518d629-75b1-4f3b-9e99-7268c4502c70", "Customer", "CUSTOMER" },
                    { "edd280f2-8760-4a4a-bc4f-4d6a2ec324dc", "649f22ed-d97f-4fa1-82c1-53d2782548c8", "Employee", "EMPLOYEE" },
                    { "45c3da44-951a-4a95-8fc9-8ae9ede41e50", "5901bd22-3d70-4257-998d-6bce7ebad71c", "Organic Compost Advocate", "ORG COMP ADV" }
                });
        }
    }
}
