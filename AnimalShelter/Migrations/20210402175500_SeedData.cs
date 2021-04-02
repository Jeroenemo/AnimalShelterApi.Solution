using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Species = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Admitted = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Admitted", "Age", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 2, 10, 55, 0, 421, DateTimeKind.Local).AddTicks(9450), 3, "Male", "Attila", "Cat" },
                    { 2, new DateTime(2021, 4, 2, 10, 55, 0, 421, DateTimeKind.Local).AddTicks(9850), 10, "Male", "RZA", "Cat" },
                    { 3, new DateTime(2021, 4, 2, 10, 55, 0, 421, DateTimeKind.Local).AddTicks(9860), 1, "Female", "Maple", "Chicken" },
                    { 4, new DateTime(2021, 4, 2, 10, 55, 0, 421, DateTimeKind.Local).AddTicks(9860), 2, "Female", "Beatrix", "Chicken" },
                    { 5, new DateTime(2021, 4, 2, 10, 55, 0, 421, DateTimeKind.Local).AddTicks(9860), 12, "Female", "Petunia", "Donkey" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
