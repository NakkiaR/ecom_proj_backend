using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class ReSeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe8f05f5-d6ae-4f02-88dd-9e1c87ad780c", "a8fee824-c239-4d3a-9940-76f5ce684ab0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a25ef7c1-170a-4c65-b676-84c2b94a332c", "c1a2cbcb-e3e7-4503-ad22-655c6c3b0244", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25ef7c1-170a-4c65-b676-84c2b94a332c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe8f05f5-d6ae-4f02-88dd-9e1c87ad780c");
        }
    }
}
