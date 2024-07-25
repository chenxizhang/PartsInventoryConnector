﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PartsInventoryConnector.Data;

#nullable disable

namespace PartsInventoryConnector.Migrations
{
    [DbContext(typeof(ApplianceDbContext))]
    [Migration("20240724094301_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("PartsInventoryConnector.Data.AppliancePart", b =>
                {
                    b.Property<int>("PartNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Appliances")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Inventory")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("datetime()");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("PartNumber");

                    b.ToTable("Parts");
                });
#pragma warning restore 612, 618
        }
    }
}
