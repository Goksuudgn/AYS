﻿// <auto-generated />
using System;
using AYS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AYS.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240812093236_StartUp")]
    partial class StartUp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AYS.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AYS.Models.Device", b =>
                {
                    b.Property<int>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeviceId"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Consumption")
                        .HasColumnType("int");

                    b.Property<bool>("IsOn")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("WarrantyExpiryDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DeviceId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RoomId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("AYS.Models.DevicePhoto", b =>
                {
                    b.Property<int>("DevicePhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DevicePhotoId"));

                    b.Property<int>("DeviceId")
                        .HasColumnType("int");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DevicePhotoId");

                    b.HasIndex("DeviceId");

                    b.ToTable("DevicePhotos");
                });

            modelBuilder.Entity("AYS.Models.Home", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("AYS.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"));

                    b.Property<int>("HomeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomId");

                    b.HasIndex("HomeId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("AYS.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AYS.Models.Device", b =>
                {
                    b.HasOne("AYS.Models.Category", "Category")
                        .WithMany("Devices")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AYS.Models.Room", "Room")
                        .WithMany("Devices")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("AYS.Models.DevicePhoto", b =>
                {
                    b.HasOne("AYS.Models.Device", "Device")
                        .WithMany("DevicePhotos")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });

            modelBuilder.Entity("AYS.Models.Home", b =>
                {
                    b.HasOne("AYS.Models.User", "User")
                        .WithMany("Homes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AYS.Models.Room", b =>
                {
                    b.HasOne("AYS.Models.Home", "Home")
                        .WithMany("Rooms")
                        .HasForeignKey("HomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Home");
                });

            modelBuilder.Entity("AYS.Models.Category", b =>
                {
                    b.Navigation("Devices");
                });

            modelBuilder.Entity("AYS.Models.Device", b =>
                {
                    b.Navigation("DevicePhotos");
                });

            modelBuilder.Entity("AYS.Models.Home", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("AYS.Models.Room", b =>
                {
                    b.Navigation("Devices");
                });

            modelBuilder.Entity("AYS.Models.User", b =>
                {
                    b.Navigation("Homes");
                });
#pragma warning restore 612, 618
        }
    }
}
