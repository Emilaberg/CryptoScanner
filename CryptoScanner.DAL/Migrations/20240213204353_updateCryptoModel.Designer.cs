﻿// <auto-generated />
using System;
using CryptoScanner.DAL.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CryptoScanner.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240213204353_updateCryptoModel")]
    partial class updateCryptoModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CryptoScanner.DAL.Models.CryptoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Ath")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Market_Cap_Rank")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price_In_Usd")
                        .HasColumnType("float");

                    b.Property<double?>("Usd_High_24H")
                        .HasColumnType("float");

                    b.Property<double?>("Usd_Low_24H")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Cryptos");
                });
#pragma warning restore 612, 618
        }
    }
}
