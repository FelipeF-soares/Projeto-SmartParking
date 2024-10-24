﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartParkWeb.DataAccess.SmartParkingContext;

#nullable disable

namespace SmartParkWeb.DataAccess.Migrations
{
    [DbContext(typeof(SmartParkContext))]
    [Migration("20241024130536_CreateDb")]
    partial class CreateDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("SmartParkWeb.Domain.Events.EventVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Entry")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("Exit")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("EventsVehicle");
                });

            modelBuilder.Entity("SmartParkWeb.Domain.People.Military", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IdentificationDocument")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Re")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Military");
                });

            modelBuilder.Entity("SmartParkWeb.Domain.Thing.IDdriver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("MilitaryId")
                        .HasColumnType("int");

                    b.Property<string>("RegisterNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Validity")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("MilitaryId")
                        .IsUnique();

                    b.ToTable("IDsdriver");
                });

            modelBuilder.Entity("SmartParkWeb.Domain.Thing.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MilitaryId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("MilitaryId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("SmartParkWeb.Domain.Events.EventVehicle", b =>
                {
                    b.HasOne("SmartParkWeb.Domain.Thing.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("SmartParkWeb.Domain.Thing.IDdriver", b =>
                {
                    b.HasOne("SmartParkWeb.Domain.People.Military", "Military")
                        .WithOne("IDdriver")
                        .HasForeignKey("SmartParkWeb.Domain.Thing.IDdriver", "MilitaryId");

                    b.Navigation("Military");
                });

            modelBuilder.Entity("SmartParkWeb.Domain.Thing.Vehicle", b =>
                {
                    b.HasOne("SmartParkWeb.Domain.People.Military", "Military")
                        .WithMany("Vehicles")
                        .HasForeignKey("MilitaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Military");
                });

            modelBuilder.Entity("SmartParkWeb.Domain.People.Military", b =>
                {
                    b.Navigation("IDdriver");

                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
