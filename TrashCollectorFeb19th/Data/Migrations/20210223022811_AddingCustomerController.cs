using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorFeb19th.Data.Migrations
{
    public partial class AddingCustomerController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Street_Address = table.Column<string>(nullable: true),
                    Zip_Code = table.Column<string>(nullable: true),
                    Select_ChangePickUp = table.Column<string>(nullable: true),
                    ExtraPickUp = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f0df9fb8-36f4-4c84-83d9-a5e0d3f8fe68", "04c13552-ddf2-43f5-a3e6-c5c3950c4a96", "Admin", "ADMIN" },
                    { "7db32630-ecdf-4316-8436-bacfefc0c560", "7c7b0172-6b34-4c83-b31f-0d9ee566aed9", "Customer", "CUSTOMER" },
                    { "8114ef51-8697-432e-9a60-64b6abd354af", "2dccb1bd-5555-4143-8cef-554cd7cec238", "Employee", "EMPLOYEE" },
                    { "d220817c-d2f0-40e8-9e0f-059bed680962", "d73e8e15-ef2c-4fd1-8c6d-c94949dad181", "Organic Compost Advocate", "ORG COMP ADV" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7db32630-ecdf-4316-8436-bacfefc0c560");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8114ef51-8697-432e-9a60-64b6abd354af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d220817c-d2f0-40e8-9e0f-059bed680962");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0df9fb8-36f4-4c84-83d9-a5e0d3f8fe68");

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
    }
}
