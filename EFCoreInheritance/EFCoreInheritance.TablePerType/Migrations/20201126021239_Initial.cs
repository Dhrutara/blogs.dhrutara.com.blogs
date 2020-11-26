using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreInheritance.TablePerType.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrganizationPolicyTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyTemplateHierarchy = table.Column<int>(type: "int", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationPolicyTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegionPolicyTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionPolicyTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegionPolicyTemplate_OrganizationPolicyTemplate_Id",
                        column: x => x.Id,
                        principalTable: "OrganizationPolicyTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CountryPolicyTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryPolicyTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountryPolicyTemplate_RegionPolicyTemplate_Id",
                        column: x => x.Id,
                        principalTable: "RegionPolicyTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryPolicyTemplate");

            migrationBuilder.DropTable(
                name: "RegionPolicyTemplate");

            migrationBuilder.DropTable(
                name: "OrganizationPolicyTemplate");
        }
    }
}
