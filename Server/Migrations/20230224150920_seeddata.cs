using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorCodeFirst.Server.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ElementTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ElementTypeName", "IsDeleted", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2023, 2, 24, 15, 9, 19, 678, DateTimeKind.Utc).AddTicks(561), 1, "Doors", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ElementTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ElementTypeName", "IsDeleted", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2023, 2, 24, 15, 9, 19, 678, DateTimeKind.Utc).AddTicks(2348), 1, "Window", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ElementTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ElementTypeName", "IsDeleted", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2023, 2, 24, 15, 9, 19, 678, DateTimeKind.Utc).AddTicks(2358), 1, "Table", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ElementTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ElementTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ElementTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
