using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorFeb19th.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67190c3c-c1b1-4b90-8ce3-483269daf0b5");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "67190c3c-c1b1-4b90-8ce3-483269daf0b5", "26f242df-e923-49bc-80f3-aa6edd5cd7a5", "Admin", "ADMIN" });
        }
    }
}
