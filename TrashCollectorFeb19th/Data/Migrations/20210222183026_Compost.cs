using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorFeb19th.Data.Migrations
{
    public partial class Compost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a4b19a6-6aad-4111-9830-29a0bec95cc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ce818c2-1cb3-4de1-9617-f0e618a26f47");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e90b9b9a-1d50-4015-98b5-e02c7cc838ad");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "6ce818c2-1cb3-4de1-9617-f0e618a26f47", "5c8ef3ab-e490-422a-97c1-7de3ffe27c10", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e90b9b9a-1d50-4015-98b5-e02c7cc838ad", "0499d5b2-cadb-443f-ae00-1fc6cbead265", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a4b19a6-6aad-4111-9830-29a0bec95cc3", "7688453f-420e-4aca-848c-9254db2d3996", "Employee", "EMPLOYEE" });
        }
    }
}
