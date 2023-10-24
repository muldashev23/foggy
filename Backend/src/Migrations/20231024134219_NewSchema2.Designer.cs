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
    [Migration("20231024134219_NewSchema2")]
    partial class NewSchema2
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
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
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
                            PasswordHash = new byte[] { 79, 191, 232, 213, 129, 251, 100, 198, 40, 171, 235, 206, 7, 45, 170, 146, 36, 141, 150, 8, 254, 118, 118, 119, 235, 232, 202, 53, 227, 187, 129, 122, 209, 174, 161, 239, 115, 149, 182, 68, 158, 146, 71, 32, 185, 243, 47, 86, 66, 31, 74, 224, 200, 57, 67, 80, 66, 254, 99, 91, 39, 212, 248, 171 },
                            PasswordSalt = new byte[] { 149, 213, 226, 56, 221, 115, 232, 173, 149, 219, 165, 194, 114, 34, 104, 240, 120, 234, 152, 14, 224, 61, 229, 48, 23, 250, 83, 20, 55, 38, 139, 198, 147, 83, 37, 203, 5, 104, 140, 246, 213, 69, 34, 119, 137, 119, 174, 135, 43, 56, 131, 189, 85, 249, 186, 113, 134, 161, 126, 205, 55, 150, 249, 94, 243, 232, 223, 68, 97, 101, 40, 60, 109, 34, 52, 71, 244, 57, 247, 251, 178, 235, 32, 110, 50, 0, 10, 171, 120, 205, 107, 117, 60, 24, 239, 85, 14, 118, 159, 92, 211, 54, 159, 147, 58, 12, 252, 219, 71, 97, 82, 19, 160, 182, 80, 144, 27, 180, 168, 233, 40, 7, 126, 28, 111, 248, 190, 12 },
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

                    b.Property<int>("DayNum")
                        .HasColumnType("integer");

                    b.Property<int>("TimeStart")
                        .HasColumnType("integer");

                    b.Property<int>("WeekNum")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique();

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("Backend.Data.Entities.Shift", b =>
                {
                    b.HasOne("Backend.Data.Entities.AppUser", "AppUser")
                        .WithOne("Shift")
                        .HasForeignKey("Backend.Data.Entities.Shift", "AppUserId")
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
