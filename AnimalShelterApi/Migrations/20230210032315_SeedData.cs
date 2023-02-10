using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Residents",
                columns: new[] { "ResidentId", "AdmissionDate", "Chipped", "Name", "Notes", "Sex", "Species" },
                values: new object[] { 1, new DateTime(2023, 2, 9, 19, 23, 15, 777, DateTimeKind.Local).AddTicks(5845), true, "Paul", "Sunny Disposition", "Male", "Cat" });

            migrationBuilder.InsertData(
                table: "Residents",
                columns: new[] { "ResidentId", "AdmissionDate", "Chipped", "Name", "Notes", "Sex", "Species" },
                values: new object[] { 2, new DateTime(2023, 2, 9, 19, 23, 15, 777, DateTimeKind.Local).AddTicks(5873), false, "Scruff", "Does not like people", "Male", "Dog" });

            migrationBuilder.InsertData(
                table: "Residents",
                columns: new[] { "ResidentId", "AdmissionDate", "Chipped", "Name", "Notes", "Sex", "Species" },
                values: new object[] { 3, new DateTime(2023, 2, 9, 19, 23, 15, 777, DateTimeKind.Local).AddTicks(5875), true, "Traci", "I love this dog", "Female", "Dog" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 3);
        }
    }
}
