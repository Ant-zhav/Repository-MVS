using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Complex742.Migrations
{
    public partial class InitCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypeEquipment",
                columns: table => new
                {
                    typeEquipmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeEquipment", x => x.typeEquipmentId);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    equipmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    masterEquipmentequipmentId = table.Column<int>(type: "integer", nullable: true),
                    typeEquipmentId = table.Column<int>(type: "integer", nullable: true),
                    nameEquipment = table.Column<string>(type: "text", nullable: true),
                    modelEquipment = table.Column<string>(type: "text", nullable: true),
                    serialNumberEquipment = table.Column<string>(type: "text", nullable: true),
                    manufactorerEquipment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.equipmentId);
                    table.ForeignKey(
                        name: "FK_Equipment_Equipment_masterEquipmentequipmentId",
                        column: x => x.masterEquipmentequipmentId,
                        principalTable: "Equipment",
                        principalColumn: "equipmentId");
                    table.ForeignKey(
                        name: "FK_Equipment_TypeEquipment_typeEquipmentId",
                        column: x => x.typeEquipmentId,
                        principalTable: "TypeEquipment",
                        principalColumn: "typeEquipmentId");
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    propertyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    typeEquipmentId = table.Column<int>(type: "integer", nullable: true),
                    nameProperty = table.Column<string>(type: "text", nullable: true),
                    unitProperty = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.propertyId);
                    table.ForeignKey(
                        name: "FK_Property_TypeEquipment_typeEquipmentId",
                        column: x => x.typeEquipmentId,
                        principalTable: "TypeEquipment",
                        principalColumn: "typeEquipmentId");
                });

            migrationBuilder.CreateTable(
                name: "TypeWork",
                columns: table => new
                {
                    typeWorkId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    typeEquipmentId = table.Column<int>(type: "integer", nullable: true),
                    nameWork = table.Column<string>(type: "text", nullable: true),
                    periodicityWork = table.Column<double>(type: "double precision", nullable: false),
                    laboriousness = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeWork", x => x.typeWorkId);
                    table.ForeignKey(
                        name: "FK_TypeWork_TypeEquipment_typeEquipmentId",
                        column: x => x.typeEquipmentId,
                        principalTable: "TypeEquipment",
                        principalColumn: "typeEquipmentId");
                });

            migrationBuilder.CreateTable(
                name: "PropertyValue",
                columns: table => new
                {
                    propertyValueId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    equipmentId = table.Column<int>(type: "integer", nullable: true),
                    propertyId = table.Column<int>(type: "integer", nullable: true),
                    value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyValue", x => x.propertyValueId);
                    table.ForeignKey(
                        name: "FK_PropertyValue_Equipment_equipmentId",
                        column: x => x.equipmentId,
                        principalTable: "Equipment",
                        principalColumn: "equipmentId");
                    table.ForeignKey(
                        name: "FK_PropertyValue_Property_propertyId",
                        column: x => x.propertyId,
                        principalTable: "Property",
                        principalColumn: "propertyId");
                });

            migrationBuilder.CreateTable(
                name: "Work",
                columns: table => new
                {
                    workId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    typeWorkId = table.Column<int>(type: "integer", nullable: true),
                    lastDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    equipmentId = table.Column<int>(type: "integer", nullable: true),
                    result = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Work", x => x.workId);
                    table.ForeignKey(
                        name: "FK_Work_Equipment_equipmentId",
                        column: x => x.equipmentId,
                        principalTable: "Equipment",
                        principalColumn: "equipmentId");
                    table.ForeignKey(
                        name: "FK_Work_TypeWork_typeWorkId",
                        column: x => x.typeWorkId,
                        principalTable: "TypeWork",
                        principalColumn: "typeWorkId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_masterEquipmentequipmentId",
                table: "Equipment",
                column: "masterEquipmentequipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_typeEquipmentId",
                table: "Equipment",
                column: "typeEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_typeEquipmentId",
                table: "Property",
                column: "typeEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyValue_equipmentId",
                table: "PropertyValue",
                column: "equipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyValue_propertyId",
                table: "PropertyValue",
                column: "propertyId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeWork_typeEquipmentId",
                table: "TypeWork",
                column: "typeEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Work_equipmentId",
                table: "Work",
                column: "equipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Work_typeWorkId",
                table: "Work",
                column: "typeWorkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyValue");

            migrationBuilder.DropTable(
                name: "Work");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "TypeWork");

            migrationBuilder.DropTable(
                name: "TypeEquipment");
        }
    }
}
