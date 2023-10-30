﻿// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231029150258_ModifiedShift")]
    partial class ModifiedShift
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Backend.Data.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsBarmen")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsShishaMaster")
                        .HasColumnType("boolean");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@gmail.com",
                            FirstName = "murat",
                            IsBarmen = false,
                            IsShishaMaster = false,
                            PasswordHash = new byte[] { 71, 229, 137, 87, 209, 176, 16, 255, 1, 172, 48, 236, 233, 174, 157, 204, 44, 81, 50, 189, 80, 161, 149, 164, 171, 62, 101, 196, 136, 5, 214, 175, 106, 32, 119, 137, 201, 21, 163, 120, 225, 108, 33, 145, 170, 124, 199, 3, 111, 160, 171, 102, 30, 169, 34, 138, 148, 242, 108, 109, 84, 104, 181, 230 },
                            PasswordSalt = new byte[] { 74, 34, 181, 247, 227, 177, 250, 63, 182, 37, 24, 148, 162, 87, 3, 231, 12, 212, 167, 158, 38, 140, 141, 94, 21, 238, 69, 217, 57, 234, 85, 158, 55, 217, 113, 119, 231, 88, 134, 43, 55, 196, 62, 10, 253, 107, 54, 48, 122, 92, 14, 145, 233, 135, 1, 103, 168, 83, 201, 42, 35, 44, 175, 157, 122, 171, 178, 238, 228, 174, 32, 172, 157, 81, 107, 181, 20, 142, 183, 32, 85, 90, 236, 95, 56, 86, 247, 128, 120, 51, 120, 157, 116, 220, 82, 180, 84, 150, 175, 226, 132, 188, 68, 140, 241, 60, 242, 70, 78, 154, 169, 113, 69, 97, 145, 163, 166, 45, 233, 176, 31, 14, 252, 108, 237, 114, 2, 134 },
                            Role = "Manager",
                            Surname = "muldashev"
                        });
                });

            modelBuilder.Entity("Backend.Data.Entities.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AppUserId")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("DateOfShift")
                        .HasColumnType("date");

                    b.Property<int>("TimeStart")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("Backend.Data.Entities.Shift", b =>
                {
                    b.HasOne("Backend.Data.Entities.AppUser", "AppUser")
                        .WithMany("Shift")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Backend.Data.Entities.AppUser", b =>
                {
                    b.Navigation("Shift");
                });
#pragma warning restore 612, 618
        }
    }
}