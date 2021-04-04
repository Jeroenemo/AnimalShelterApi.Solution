using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class OneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Species",
                table: "Animals");

            migrationBuilder.AddColumn<int>(
                name: "SpeciesId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    SpeciesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.SpeciesId);
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Type" },
                values: new object[] { 1, "Cat" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Type" },
                values: new object[] { 2, "Chicken" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "SpeciesId", "Type" },
                values: new object[] { 3, "Donkey" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                columns: new[] { "Admitted", "SpeciesId" },
                values: new object[] { new DateTime(2021, 4, 4, 12, 31, 57, 346, DateTimeKind.Local).AddTicks(1230), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Admitted", "SpeciesId" },
                values: new object[] { new DateTime(2021, 4, 4, 12, 31, 57, 346, DateTimeKind.Local).AddTicks(1960), 1 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Admitted", "SpeciesId" },
                values: new object[] { new DateTime(2021, 4, 4, 12, 31, 57, 346, DateTimeKind.Local).AddTicks(1970), 2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Admitted", "SpeciesId" },
                values: new object[] { new DateTime(2021, 4, 4, 12, 31, 57, 346, DateTimeKind.Local).AddTicks(1970), 2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                columns: new[] { "Admitted", "SpeciesId" },
                values: new object[] { new DateTime(2021, 4, 4, 12, 31, 57, 346, DateTimeKind.Local).AddTicks(1970), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_SpeciesId",
                table: "Animals",
                column: "SpeciesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Species_SpeciesId",
                table: "Animals",
                column: "SpeciesId",
                principalTable: "Species",
                principalColumn: "SpeciesId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Species_SpeciesId",
                table: "Animals");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropIndex(
                name: "IX_Animals_SpeciesId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "SpeciesId",
                table: "Animals");

            migrationBuilder.AddColumn<string>(
                name: "Species",
                table: "Animals",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                columns: new[] { "Admitted", "Species" },
                values: new object[] { new DateTime(2021, 4, 2, 10, 55, 0, 421, DateTimeKind.Local).AddTicks(9450), "Cat" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Admitted", "Species" },
                values: new object[] { new DateTime(2021, 4, 2, 10, 55, 0, 421, DateTimeKind.Local).AddTicks(9850), "Cat" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Admitted", "Species" },
                values: new object[] { new DateTime(2021, 4, 2, 10, 55, 0, 421, DateTimeKind.Local).AddTicks(9860), "Chicken" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Admitted", "Species" },
                values: new object[] { new DateTime(2021, 4, 2, 10, 55, 0, 421, DateTimeKind.Local).AddTicks(9860), "Chicken" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                columns: new[] { "Admitted", "Species" },
                values: new object[] { new DateTime(2021, 4, 2, 10, 55, 0, 421, DateTimeKind.Local).AddTicks(9860), "Donkey" });
        }
    }
}
