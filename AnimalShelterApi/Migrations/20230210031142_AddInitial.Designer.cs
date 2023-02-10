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
    [Migration("20230210031142_AddInitial")]
    partial class AddInitial
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
                });
#pragma warning restore 612, 618
        }
    }
}
