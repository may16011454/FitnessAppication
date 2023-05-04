using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class addIssueControllers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TechnicalIssueId",
                table: "Asset",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GeneralIssue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Details = table.Column<string>(type: "TEXT", nullable: false),
                    RecordedById = table.Column<string>(type: "TEXT", nullable: false),
                    RaisedById = table.Column<string>(type: "TEXT", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralIssue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralIssue_AspNetUsers_RaisedById",
                        column: x => x.RaisedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneralIssue_AspNetUsers_RecordedById",
                        column: x => x.RecordedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalIssue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Details = table.Column<string>(type: "TEXT", nullable: false),
                    RecordedById = table.Column<string>(type: "TEXT", nullable: false),
                    RaisedById = table.Column<string>(type: "TEXT", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalIssue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechnicalIssue_AspNetUsers_RaisedById",
                        column: x => x.RaisedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechnicalIssue_AspNetUsers_RecordedById",
                        column: x => x.RecordedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_TechnicalIssueId",
                table: "Asset",
                column: "TechnicalIssueId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralIssue_RaisedById",
                table: "GeneralIssue",
                column: "RaisedById");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralIssue_RecordedById",
                table: "GeneralIssue",
                column: "RecordedById");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalIssue_RaisedById",
                table: "TechnicalIssue",
                column: "RaisedById");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalIssue_RecordedById",
                table: "TechnicalIssue",
                column: "RecordedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Asset_TechnicalIssue_TechnicalIssueId",
                table: "Asset",
                column: "TechnicalIssueId",
                principalTable: "TechnicalIssue",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asset_TechnicalIssue_TechnicalIssueId",
                table: "Asset");

            migrationBuilder.DropTable(
                name: "GeneralIssue");

            migrationBuilder.DropTable(
                name: "TechnicalIssue");

            migrationBuilder.DropIndex(
                name: "IX_Asset_TechnicalIssueId",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "TechnicalIssueId",
                table: "Asset");
        }
    }
}
