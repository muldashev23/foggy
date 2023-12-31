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
    [Migration("20231024131511_NewSchema1")]
    partial class NewSchema1
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
                            PasswordHash = new byte[] { 69, 60, 172, 143, 16, 227, 236, 234, 147, 159, 198, 29, 216, 226, 10, 5, 26, 225, 47, 143, 24, 59, 102, 79, 103, 118, 158, 138, 156, 125, 30, 240, 248, 79, 203, 226, 45, 91, 113, 217, 179, 81, 92, 80, 93, 22, 110, 112, 100, 62, 9, 239, 87, 14, 121, 60, 101, 108, 183, 14, 148, 152, 169, 102 },
                            PasswordSalt = new byte[] { 200, 150, 170, 208, 84, 17, 186, 83, 2, 83, 11, 2, 243, 32, 204, 171, 195, 129, 182, 233, 172, 100, 149, 77, 72, 70, 198, 211, 23, 205, 58, 52, 147, 0, 14, 206, 150, 98, 181, 116, 34, 73, 254, 156, 56, 137, 85, 236, 17, 34, 184, 112, 21, 193, 130, 68, 26, 243, 44, 172, 2, 205, 217, 218, 173, 158, 250, 59, 107, 21, 132, 56, 54, 215, 205, 170, 175, 108, 99, 2, 244, 119, 184, 224, 51, 200, 209, 79, 146, 121, 67, 27, 79, 167, 177, 98, 234, 240, 199, 56, 172, 34, 7, 123, 2, 163, 29, 178, 205, 74, 113, 207, 123, 189, 197, 162, 10, 49, 193, 65, 23, 124, 170, 174, 110, 17, 38, 231 },
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
