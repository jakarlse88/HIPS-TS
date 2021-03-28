using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HIPS_TS.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "technique");

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "technique",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    UpdatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Description",
                schema: "technique",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    UpdatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jin",
                schema: "technique",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    UpdatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Type",
                schema: "technique",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    UdatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryName",
                schema: "technique",
                columns: table => new
                {
                    NameId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_techniquetypename", x => new { x.NameId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CategoryName_Category",
                        column: x => x.CategoryId,
                        principalSchema: "technique",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JinName",
                schema: "technique",
                columns: table => new
                {
                    JinId = table.Column<int>(type: "int", nullable: false),
                    NameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jinname", x => new { x.JinId, x.NameId });
                    table.ForeignKey(
                        name: "FK_JinName_Jin",
                        column: x => x.JinId,
                        principalSchema: "technique",
                        principalTable: "Jin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Technique",
                schema: "technique",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    UpdatedBy = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    JinId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technique", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Technique_Jin",
                        column: x => x.JinId,
                        principalSchema: "technique",
                        principalTable: "Jin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypeName",
                schema: "technique",
                columns: table => new
                {
                    NameId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typename", x => new { x.NameId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_TypeName_Type",
                        column: x => x.TypeId,
                        principalSchema: "technique",
                        principalTable: "Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TechniqueCategory",
                schema: "technique",
                columns: table => new
                {
                    TechniqueId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_techniquecategory", x => new { x.TechniqueId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_TechniqueCategory_Category",
                        column: x => x.CategoryId,
                        principalSchema: "technique",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TechniqueCategory_Technique",
                        column: x => x.TechniqueId,
                        principalSchema: "technique",
                        principalTable: "Technique",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TechniqueDescription",
                schema: "technique",
                columns: table => new
                {
                    TechniqueId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_techniquedescription", x => new { x.TechniqueId, x.DescriptionId });
                    table.ForeignKey(
                        name: "FK_TechniqueDescription_Description",
                        column: x => x.DescriptionId,
                        principalSchema: "technique",
                        principalTable: "Description",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TechniqueDescription_Technique",
                        column: x => x.TechniqueId,
                        principalSchema: "technique",
                        principalTable: "Technique",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TechniqueName",
                schema: "technique",
                columns: table => new
                {
                    NameId = table.Column<int>(type: "int", nullable: false),
                    TechniqueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_techniquename", x => new { x.NameId, x.TechniqueId });
                    table.ForeignKey(
                        name: "FK_TechniqueName_Technique",
                        column: x => x.TechniqueId,
                        principalSchema: "technique",
                        principalTable: "Technique",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TechniqueType",
                schema: "technique",
                columns: table => new
                {
                    TechniqueId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_techniquetype", x => new { x.TechniqueId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_TechniqueType_Technique",
                        column: x => x.TechniqueId,
                        principalSchema: "technique",
                        principalTable: "Technique",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TechniqueType_Type",
                        column: x => x.TypeId,
                        principalSchema: "technique",
                        principalTable: "Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fkIdx_100",
                schema: "technique",
                table: "CategoryName",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "fkIdx_317",
                schema: "technique",
                table: "JinName",
                column: "JinId");

            migrationBuilder.CreateIndex(
                name: "fkIdx_310",
                schema: "technique",
                table: "Technique",
                column: "JinId");

            migrationBuilder.CreateIndex(
                name: "fkIdx_139",
                schema: "technique",
                table: "TechniqueCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "fkIdx_142",
                schema: "technique",
                table: "TechniqueCategory",
                column: "TechniqueId");

            migrationBuilder.CreateIndex(
                name: "fkIdx_90",
                schema: "technique",
                table: "TechniqueDescription",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "fkIdx_93",
                schema: "technique",
                table: "TechniqueDescription",
                column: "TechniqueId");

            migrationBuilder.CreateIndex(
                name: "fkIdx_107",
                schema: "technique",
                table: "TechniqueName",
                column: "TechniqueId");

            migrationBuilder.CreateIndex(
                name: "fkIdx_129",
                schema: "technique",
                table: "TechniqueType",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "fkIdx_132",
                schema: "technique",
                table: "TechniqueType",
                column: "TechniqueId");

            migrationBuilder.CreateIndex(
                name: "fkIdx_122",
                schema: "technique",
                table: "TypeName",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryName",
                schema: "technique");

            migrationBuilder.DropTable(
                name: "JinName",
                schema: "technique");

            migrationBuilder.DropTable(
                name: "TechniqueCategory",
                schema: "technique");

            migrationBuilder.DropTable(
                name: "TechniqueDescription",
                schema: "technique");

            migrationBuilder.DropTable(
                name: "TechniqueName",
                schema: "technique");

            migrationBuilder.DropTable(
                name: "TechniqueType",
                schema: "technique");

            migrationBuilder.DropTable(
                name: "TypeName",
                schema: "technique");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "technique");

            migrationBuilder.DropTable(
                name: "Description",
                schema: "technique");

            migrationBuilder.DropTable(
                name: "Technique",
                schema: "technique");

            migrationBuilder.DropTable(
                name: "Type",
                schema: "technique");

            migrationBuilder.DropTable(
                name: "Jin",
                schema: "technique");
        }
    }
}
