﻿// <auto-generated />
using System;
using FeuerwehrApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FeuerwehrApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241116172821_FeuerwehrmannUpdateNeu")]
    partial class FeuerwehrmannUpdateNeu
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FeuerwehrApp.Models.Atemschutzgeraet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CheckDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiringDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Geraete");
                });

            modelBuilder.Entity("FeuerwehrApp.Models.Atemschutzmaske", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CheckDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiringDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPersonalized")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("StoragePlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Masken");
                });

            modelBuilder.Entity("FeuerwehrApp.Models.Feuerwehrmann", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Geburtsdatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("dienstGrad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("preName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Feuerwehrmann");
                });

            modelBuilder.Entity("FeuerwehrApp.Models.Fuehrerschein", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CheckDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiringDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FSKlasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOK")
                        .HasColumnType("bit");

                    b.Property<string>("Usage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("preName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DrivingLicense");
                });

            modelBuilder.Entity("FeuerwehrApp.Models.Geraetetraeger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Belastung")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BelastungExpiring")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Einsatz")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EinsatzExpiring")
                        .HasColumnType("datetime2");

                    b.PrimitiveCollection<string>("ExpiringDates")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("G26")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("G26Expiring")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsTauglich")
                        .HasColumnType("bit");

                    b.Property<bool>("IsU50")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Unterweisung")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UnterweisungExpiring")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("preName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AGT");
                });
#pragma warning restore 612, 618
        }
    }
}
