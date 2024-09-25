using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillsShareConnect.Migrations
{
    /// <inheritdoc />
    public partial class Databasescaffold : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrganizationEmail",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3952d38f-2c3f-4ebc-a8cb-8834b1023cb6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b84061fc-7e5e-402c-b1bc-d2f028d9b65a", "AQAAAAIAAYagAAAAEFWp9c4RWlIaYjbNmmBWWd9oCLGQNRpqDwBNw6YJBAJHljqfI7ATM2IXhEhGzsoF3Q==", "3df22955-8e98-4541-ae4c-54177ed01f88" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrganizationEmail",
                table: "Organizations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3952d38f-2c3f-4ebc-a8cb-8834b1023cb6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d22d6f48-9d72-4cf6-8c44-2385b6b470d1", "AQAAAAIAAYagAAAAEHdBuTrcLRF78XGGumLnvFnpIf8ukUAdkDGG1aPUhNQVPLHglvBVzxV1S/uD9Tu7ow==", "7bfd633b-7b5e-42eb-8316-8e98da7222ba" });
        }
    }
}
