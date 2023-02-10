﻿// <auto-generated />
using System;
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    [Migration("20230210032315_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Resident", b =>
                {
                    b.Property<int>("ResidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AdmissionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Chipped")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext");

                    b.Property<string>("Sex")
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .HasColumnType("longtext");

                    b.HasKey("ResidentId");

                    b.ToTable("Residents");

                    b.HasData(
                        new
                        {
                            ResidentId = 1,
                            AdmissionDate = new DateTime(2023, 2, 9, 19, 23, 15, 777, DateTimeKind.Local).AddTicks(5845),
                            Chipped = true,
                            Name = "Paul",
                            Notes = "Sunny Disposition",
                            Sex = "Male",
                            Species = "Cat"
                        },
                        new
                        {
                            ResidentId = 2,
                            AdmissionDate = new DateTime(2023, 2, 9, 19, 23, 15, 777, DateTimeKind.Local).AddTicks(5873),
                            Chipped = false,
                            Name = "Scruff",
                            Notes = "Does not like people",
                            Sex = "Male",
                            Species = "Dog"
                        },
                        new
                        {
                            ResidentId = 3,
                            AdmissionDate = new DateTime(2023, 2, 9, 19, 23, 15, 777, DateTimeKind.Local).AddTicks(5875),
                            Chipped = true,
                            Name = "Traci",
                            Notes = "I love this dog",
                            Sex = "Female",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
