﻿// <auto-generated />
using System;
using APIs.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIs.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20240523215046_data")]
    partial class data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("APIs.Model.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GovernorateId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GovernorateId");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GovernorateId = 1,
                            Name = "Cairo Downtown"
                        },
                        new
                        {
                            Id = 2,
                            GovernorateId = 1,
                            Name = "Zamalek"
                        },
                        new
                        {
                            Id = 3,
                            GovernorateId = 1,
                            Name = "Kasr El Nile"
                        },
                        new
                        {
                            Id = 4,
                            GovernorateId = 1,
                            Name = "Rehab"
                        },
                        new
                        {
                            Id = 5,
                            GovernorateId = 1,
                            Name = "Katameya"
                        },
                        new
                        {
                            Id = 6,
                            GovernorateId = 1,
                            Name = "Madinty"
                        },
                        new
                        {
                            Id = 7,
                            GovernorateId = 1,
                            Name = "Rod Alfarag"
                        },
                        new
                        {
                            Id = 8,
                            GovernorateId = 1,
                            Name = "Sheraton"
                        },
                        new
                        {
                            Id = 9,
                            GovernorateId = 1,
                            Name = "El-Gamaleya"
                        },
                        new
                        {
                            Id = 10,
                            GovernorateId = 1,
                            Name = "10th of Ramadan City"
                        },
                        new
                        {
                            Id = 11,
                            GovernorateId = 1,
                            Name = "Helmeyat Alzaytoun"
                        },
                        new
                        {
                            Id = 12,
                            GovernorateId = 1,
                            Name = "New Nozha"
                        },
                        new
                        {
                            Id = 13,
                            GovernorateId = 1,
                            Name = "Capital New"
                        },
                        new
                        {
                            Id = 14,
                            GovernorateId = 2,
                            Name = "السادس من أكتوبر"
                        },
                        new
                        {
                            Id = 15,
                            GovernorateId = 2,
                            Name = "Sixth of October"
                        },
                        new
                        {
                            Id = 16,
                            GovernorateId = 2,
                            Name = "Cheikh Zayed"
                        },
                        new
                        {
                            Id = 17,
                            GovernorateId = 2,
                            Name = "Hawamdiyah"
                        },
                        new
                        {
                            Id = 18,
                            GovernorateId = 2,
                            Name = "Al Badrasheen"
                        },
                        new
                        {
                            Id = 19,
                            GovernorateId = 2,
                            Name = "Saf"
                        },
                        new
                        {
                            Id = 20,
                            GovernorateId = 2,
                            Name = "Atfih"
                        },
                        new
                        {
                            Id = 21,
                            GovernorateId = 2,
                            Name = "Al Ayat"
                        },
                        new
                        {
                            Id = 22,
                            GovernorateId = 2,
                            Name = "Al-Bawaiti"
                        },
                        new
                        {
                            Id = 23,
                            GovernorateId = 2,
                            Name = "ManshiyetAl Qanater"
                        },
                        new
                        {
                            Id = 24,
                            GovernorateId = 2,
                            Name = "Oaseem"
                        },
                        new
                        {
                            Id = 25,
                            GovernorateId = 2,
                            Name = "Kerdasa"
                        },
                        new
                        {
                            Id = 26,
                            GovernorateId = 3,
                            Name = "ابو قير"
                        },
                        new
                        {
                            Id = 27,
                            GovernorateId = 3,
                            Name = "Abu Qir"
                        },
                        new
                        {
                            Id = 28,
                            GovernorateId = 3,
                            Name = "Al Ibrahimeyah"
                        },
                        new
                        {
                            Id = 29,
                            GovernorateId = 3,
                            Name = "Azarita"
                        },
                        new
                        {
                            Id = 30,
                            GovernorateId = 3,
                            Name = "Anfoushi"
                        },
                        new
                        {
                            Id = 31,
                            GovernorateId = 3,
                            Name = "Dekheila"
                        },
                        new
                        {
                            Id = 32,
                            GovernorateId = 3,
                            Name = "El Soyof"
                        },
                        new
                        {
                            Id = 33,
                            GovernorateId = 3,
                            Name = "Ameria"
                        },
                        new
                        {
                            Id = 34,
                            GovernorateId = 3,
                            Name = "El Labban"
                        },
                        new
                        {
                            Id = 35,
                            GovernorateId = 3,
                            Name = "Al Mafrouza"
                        },
                        new
                        {
                            Id = 36,
                            GovernorateId = 3,
                            Name = "El Montaza"
                        },
                        new
                        {
                            Id = 37,
                            GovernorateId = 3,
                            Name = "Mansheya"
                        },
                        new
                        {
                            Id = 38,
                            GovernorateId = 3,
                            Name = "Naseria"
                        },
                        new
                        {
                            Id = 39,
                            GovernorateId = 3,
                            Name = "Ambrozo"
                        });
                });

            modelBuilder.Entity("APIs.Model.Governorate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Governorate");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cairo"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Giza"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Alexandria"
                        });
                });

            modelBuilder.Entity("APIs.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("APIs.Model.UserAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BuildingNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlatNumber")
                        .HasColumnType("int");

                    b.Property<string>("Governate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("userID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("APIs.Model.City", b =>
                {
                    b.HasOne("APIs.Model.Governorate", "Governorate")
                        .WithMany("cities")
                        .HasForeignKey("GovernorateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governorate");
                });

            modelBuilder.Entity("APIs.Model.UserAddress", b =>
                {
                    b.HasOne("APIs.Model.User", "Users")
                        .WithMany("Addresses")
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("APIs.Model.Governorate", b =>
                {
                    b.Navigation("cities");
                });

            modelBuilder.Entity("APIs.Model.User", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}