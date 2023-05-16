using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApplication.Migrations
{
    public partial class amended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Schedule_ClassScheduleId",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_ClassScheduleId",
                table: "Equipments");

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

            migrationBuilder.DropColumn(
                name: "ClassScheduleId",
                table: "Equipments");

            migrationBuilder.CreateTable(
                name: "EquipmentListEntry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EquipmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClassScheduleId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentListEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentListEntry_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentListEntry_Schedule_ClassScheduleId",
                        column: x => x.ClassScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67717603-dbbe-4727-bb9d-0a6536311702", "99e0c630-f388-40e1-ac08-ce2373a20341", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "74bed684-c6a2-4e8b-803a-a37fb6ba5859", "07f344bf-f5ce-40ab-b3b1-bbf5ae8a786c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "daf39683-b11b-490d-884b-da15c346f684", "45b614a7-64c3-4824-a9cb-ecb426bdbb08", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db752949-4c56-4bd1-88a1-b60ca8f5742b", "edf66960-438b-4e7d-abd0-027b019ed65d", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2dea8e58-0e17-46a9-beb1-6827ce5bb077", 0, "c9ae0a29-9257-48d2-af8b-9587a6482ce6", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEMWv8u8qj7cBGeC4ZUx50RNpRkRw7mNDumMNEzUoNd3DibTlqeU4xppXcGQBCylNsQ==", null, false, "4e3132f8-8851-4949-8889-19d979c2de98", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "74bed684-c6a2-4e8b-803a-a37fb6ba5859", "2dea8e58-0e17-46a9-beb1-6827ce5bb077" });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentListEntry_ClassScheduleId",
                table: "EquipmentListEntry",
                column: "ClassScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentListEntry_EquipmentId",
                table: "EquipmentListEntry",
                column: "EquipmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentListEntry");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67717603-dbbe-4727-bb9d-0a6536311702");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daf39683-b11b-490d-884b-da15c346f684");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db752949-4c56-4bd1-88a1-b60ca8f5742b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "74bed684-c6a2-4e8b-803a-a37fb6ba5859", "2dea8e58-0e17-46a9-beb1-6827ce5bb077" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74bed684-c6a2-4e8b-803a-a37fb6ba5859");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dea8e58-0e17-46a9-beb1-6827ce5bb077");

            migrationBuilder.AddColumn<int>(
                name: "ClassScheduleId",
                table: "Equipments",
                type: "INTEGER",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_ClassScheduleId",
                table: "Equipments",
                column: "ClassScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Schedule_ClassScheduleId",
                table: "Equipments",
                column: "ClassScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id");
        }
    }
}
