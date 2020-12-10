using Microsoft.EntityFrameworkCore.Migrations;

namespace P3DedicApp.Data.Migrations
{
    public partial class Music : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "5bb47cb7-5434-4617-95aa-1693ecb72c9c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMINUSER",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3eb70acc-12f3-4ef5-9fe5-712bfc67d22b", "AQAAAAEAACcQAAAAEMdm+QAwp3HhBogA0iHc5QmiXw+mJ1N+psPII45XuuOcb+ckJqW5QK/NhB63Yc2hsw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "df56eff4-6e9c-4d58-9bd7-d0098cdc5c70");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ADMINUSER",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a87bdb40-b741-4b3b-9378-2a229a67b477", "AQAAAAEAACcQAAAAEDOH5aSEkFa+QyV/1eiT0fZE5c6+mMWFGzVG2L1yqDS+LWvf7Nq3xa5MfzntibVqgA==" });
        }
    }
}
