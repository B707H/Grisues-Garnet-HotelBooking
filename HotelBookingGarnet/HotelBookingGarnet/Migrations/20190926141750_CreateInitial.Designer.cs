﻿// <auto-generated />
using System;
using HotelBookingGarnet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelBookingGarnet.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190926141750_CreateInitial")]
    partial class CreateInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HotelBookingGarnet.Models.Hotel", b =>
                {
                    b.Property<long>("HotelId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Description");

                    b.Property<string>("HotelName");

                    b.Property<int>("Price");

                    b.Property<long?>("PropertyTypeId");

                    b.Property<string>("Region");

                    b.Property<int>("StarRating");

                    b.Property<string>("UserId");

                    b.HasKey("HotelId");

                    b.HasIndex("PropertyTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("HotelBookingGarnet.Models.HotelPropertyType", b =>
                {
                    b.Property<long>("HotelId");

                    b.Property<long>("PropertyTypeId");

                    b.HasKey("HotelId", "PropertyTypeId");

                    b.HasIndex("PropertyTypeId");

                    b.ToTable("HotelPropertyType");
                });

            modelBuilder.Entity("HotelBookingGarnet.Models.PropertyType", b =>
                {
                    b.Property<long>("PropertyTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("PropertyTypeId");

                    b.ToTable("PropertyTypes");
                });

            modelBuilder.Entity("HotelBookingGarnet.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "028608e5-4700-4104-8ea4-3293b211f8d7",
                            ConcurrencyStamp = "465ecbd3-151b-41cf-acea-a522ff124509",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "6ab00165-4f7d-46fd-a03f-ccef9d29d35d",
                            ConcurrencyStamp = "9575b562-b19f-49e6-8849-7ec76ca6fb6e",
                            Name = "Guest",
                            NormalizedName = "GUEST"
                        },
                        new
                        {
                            Id = "b1060387-2e82-4929-97e5-3b6a7934054c",
                            ConcurrencyStamp = "830cc5cd-b13d-46e7-8753-38d72cda47f7",
                            Name = "Hotel Manager",
                            NormalizedName = "HOTEL MANAGER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HotelBookingGarnet.Models.Hotel", b =>
                {
                    b.HasOne("HotelBookingGarnet.Models.PropertyType", "PropertyType")
                        .WithMany()
                        .HasForeignKey("PropertyTypeId");

                    b.HasOne("HotelBookingGarnet.Models.User")
                        .WithMany("Hotels")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("HotelBookingGarnet.Models.HotelPropertyType", b =>
                {
                    b.HasOne("HotelBookingGarnet.Models.Hotel", "Hotel")
                        .WithMany("HotelPropertyTypes")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HotelBookingGarnet.Models.PropertyType", "PropertyType")
                        .WithMany("HotelPropertyTypes")
                        .HasForeignKey("PropertyTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HotelBookingGarnet.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HotelBookingGarnet.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HotelBookingGarnet.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HotelBookingGarnet.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
