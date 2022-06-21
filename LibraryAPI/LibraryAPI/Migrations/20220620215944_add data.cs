using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAPI.Migrations
{
    public partial class adddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Name", "Price", "Type", "pageSize" },
                values: new object[,]
                {
                    { 1, "Dostoyevski", "Suc ve Ceza", 45, "Roman", 560 },
                    { 2, "Arif Ergin", "Tekvin", 56, "Roman", 760 },
                    { 3, "Ali", "Cin Ali", 10, "Çocuk", 870 },
                    { 4, "JR:R TOLKIEN", "Yüzüklerin Efendisi", 90, "Bilim Kurgu", 900 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
