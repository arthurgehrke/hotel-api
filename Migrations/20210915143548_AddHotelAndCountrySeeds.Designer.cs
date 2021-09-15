﻿// <auto-generated />
using HotelApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace hotel_api.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210915143548_AddHotelAndCountrySeeds")]
    partial class AddHotelAndCountrySeeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("HotelApi.Domain.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("ShortName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "any_name_1",
                            ShortName = "any_short_name_1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "any_name_2",
                            ShortName = "any_short_name_2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "any_name_3",
                            ShortName = "any_short_name_3"
                        });
                });

            modelBuilder.Entity("HotelApi.Domain.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("Rating")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "any_address_1",
                            CountryId = 1,
                            Name = "any_name_1",
                            Rating = 2.5
                        },
                        new
                        {
                            Id = 2,
                            Address = "any_address_2",
                            CountryId = 2,
                            Name = "any_name_2",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 3,
                            Address = "any_short_name_3",
                            CountryId = 1,
                            Name = "any_name_3",
                            Rating = 3.5
                        });
                });

            modelBuilder.Entity("HotelApi.Domain.Hotel", b =>
                {
                    b.HasOne("HotelApi.Domain.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}