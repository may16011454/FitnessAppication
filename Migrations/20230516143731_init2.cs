using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApplication.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33db995c-8ddc-41f4-9fd3-24bd51fe1c35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f8a7676-5cc6-44e0-a829-1f4ae8546279");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd8ea1ca-a39a-4b02-9126-65981786baae");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77f9bf70-a67e-487d-89f1-a4ea30314afb", "2f066558-f895-4d3d-9936-02a862c313fd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77f9bf70-a67e-487d-89f1-a4ea30314afb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f066558-f895-4d3d-9936-02a862c313fd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e076e3b-2841-4f20-a836-99fbff457a27", "89bf8a92-08e5-470d-b1bc-6e7181009d68", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4edeb530-0478-4938-ba90-a604decf9bb1", "5e8d6033-69ec-403f-a82e-1a211802e4e4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5bc08f97-75aa-4a25-9998-6933430d6298", "cbe41e93-e412-4d72-aabe-f9ea65ab0f96", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f833b40c-1813-41a6-9d69-79fd27bd453f", "22c10b95-4fb4-420f-9312-fb90e5ff0d97", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8c9cae93-3309-4592-8ed6-ddcd082b6932", 0, "f4964d7a-9ee0-4027-80ff-21da683d7fb6", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEI8I69f5QmHzkXnmn1uEHsvTH5weFBQveP4trP2Qs0QnuQ6kK1wvxCAfXlLxsKbaBw==", null, false, "0d91e441-e650-4f6f-be27-b5e34b9b2bf9", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0e076e3b-2841-4f20-a836-99fbff457a27", "8c9cae93-3309-4592-8ed6-ddcd082b6932" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4edeb530-0478-4938-ba90-a604decf9bb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bc08f97-75aa-4a25-9998-6933430d6298");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f833b40c-1813-41a6-9d69-79fd27bd453f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e076e3b-2841-4f20-a836-99fbff457a27", "8c9cae93-3309-4592-8ed6-ddcd082b6932" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e076e3b-2841-4f20-a836-99fbff457a27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c9cae93-3309-4592-8ed6-ddcd082b6932");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33db995c-8ddc-41f4-9fd3-24bd51fe1c35", "73bce4e0-50d4-45c6-aed2-adc5a50831e1", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f8a7676-5cc6-44e0-a829-1f4ae8546279", "2e2019b8-a937-4ccc-8d23-4061ebc21f3d", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77f9bf70-a67e-487d-89f1-a4ea30314afb", "c6a15fc5-8090-4ab8-9292-cfe9fcea15ad", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd8ea1ca-a39a-4b02-9126-65981786baae", "bb460fc7-3455-402c-a174-1eb2b054b5a9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2f066558-f895-4d3d-9936-02a862c313fd", 0, "4f946d5a-ff06-487e-bf96-0eca0bf483bb", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBZvziF7c02HwyQD5uC4nW+aZ/0vBVFF6gQSB+OcD3C1n3ZWh4yFgbJbjHRKSMCfbA==", null, false, "26b8bec8-347a-4205-bcd5-ca4e16b80ec0", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "77f9bf70-a67e-487d-89f1-a4ea30314afb", "2f066558-f895-4d3d-9936-02a862c313fd" });
        }
    }
}
