using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookstoreManagement_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class SeedFootballFieldData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FieldTypes",
                columns: new[] { "FieldTypeId", "Description", "TypeName" },
                values: new object[,]
                {
                    { 1, "Sân cỏ nhân tạo mini", "Sân 5 người" },
                    { 2, "Sân cỏ nhân tạo trung bình", "Sân 7 người" }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "FieldId", "FieldName", "FieldTypeId", "IsActive", "PricePerHour" },
                values: new object[,]
                {
                    { 1, "Sân A1", 1, true, 300000m },
                    { 2, "Sân B2", 2, true, 500000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "FieldId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FieldTypes",
                keyColumn: "FieldTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FieldTypes",
                keyColumn: "FieldTypeId",
                keyValue: 2);
        }
    }
}
