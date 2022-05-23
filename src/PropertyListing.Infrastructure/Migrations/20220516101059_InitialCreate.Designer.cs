﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PropertyListing.Infrastructure.Persistence.Contexts;

#nullable disable

namespace PropertyListing.Infrastructure.Migrations
{
    [DbContext(typeof(PropertyListingContext))]
    [Migration("20220516101059_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.Amenity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AmenityType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Amenities");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCover")
                        .HasColumnType("bit");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.LocationAmenity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AmenityType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double?>("Lat")
                        .HasColumnType("float");

                    b.Property<double?>("Lng")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("LocationAmenities");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Userid")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.Property", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Bedrooms")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("Ensuite")
                        .HasColumnType("int");

                    b.Property<double?>("FloorArea")
                        .HasColumnType("float");

                    b.Property<bool>("ForRent")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFurnished")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOpenKitchen")
                        .HasColumnType("bit");

                    b.Property<double?>("LandArea")
                        .HasColumnType("float");

                    b.Property<string>("NearestTown")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("Rent")
                        .HasColumnType("float");

                    b.Property<int?>("Rooms")
                        .HasColumnType("int");

                    b.Property<double?>("SaleValue")
                        .HasColumnType("float");

                    b.Property<int?>("TotalBathrooms")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("YearBuilt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.PropertyAmenity", b =>
                {
                    b.Property<Guid?>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AmenityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LocationAmenityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PropertyId", "AmenityId");

                    b.HasIndex("AmenityId");

                    b.HasIndex("LocationAmenityId");

                    b.ToTable("PropertyAmenities");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.PropertyCategory", b =>
                {
                    b.Property<Guid?>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PropertyId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("PropertyCategories");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.PropertyLocationAmenity", b =>
                {
                    b.Property<Guid?>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LocationAmenityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PropertyId", "LocationAmenityId");

                    b.HasIndex("LocationAmenityId");

                    b.ToTable("PropertyLocationAmenities");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.Image", b =>
                {
                    b.HasOne("PropertyListing.ApplicationCore.Entities.Property", "Property")
                        .WithMany("Images")
                        .HasForeignKey("PropertyId");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.Property", b =>
                {
                    b.HasOne("PropertyListing.ApplicationCore.Entities.Owner", "Owner")
                        .WithMany("Properties")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.PropertyAmenity", b =>
                {
                    b.HasOne("PropertyListing.ApplicationCore.Entities.Amenity", "Amenity")
                        .WithMany("PropertyAmenities")
                        .HasForeignKey("AmenityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PropertyListing.ApplicationCore.Entities.LocationAmenity", null)
                        .WithMany("PropertyAmenities")
                        .HasForeignKey("LocationAmenityId");

                    b.HasOne("PropertyListing.ApplicationCore.Entities.Property", "Property")
                        .WithMany("PropertyAmenities")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amenity");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.PropertyCategory", b =>
                {
                    b.HasOne("PropertyListing.ApplicationCore.Entities.Category", "Category")
                        .WithMany("PropertyCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PropertyListing.ApplicationCore.Entities.Property", "Property")
                        .WithMany("PropertyCategories")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.PropertyLocationAmenity", b =>
                {
                    b.HasOne("PropertyListing.ApplicationCore.Entities.LocationAmenity", "LocationAmenity")
                        .WithMany("PropertyLocationAmenities")
                        .HasForeignKey("LocationAmenityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PropertyListing.ApplicationCore.Entities.Property", "Property")
                        .WithMany("PropertyLocationAmenities")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocationAmenity");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.Amenity", b =>
                {
                    b.Navigation("PropertyAmenities");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.Category", b =>
                {
                    b.Navigation("PropertyCategories");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.LocationAmenity", b =>
                {
                    b.Navigation("PropertyAmenities");

                    b.Navigation("PropertyLocationAmenities");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.Owner", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("PropertyListing.ApplicationCore.Entities.Property", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("PropertyAmenities");

                    b.Navigation("PropertyCategories");

                    b.Navigation("PropertyLocationAmenities");
                });
#pragma warning restore 612, 618
        }
    }
}
