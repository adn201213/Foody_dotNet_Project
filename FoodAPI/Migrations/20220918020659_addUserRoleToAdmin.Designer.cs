﻿// <auto-generated />
using System;
using FoodAPI.DAL.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodAPI.Migrations
{
    [DbContext(typeof(DbContainer))]
    [Migration("20220918020659_addUserRoleToAdmin")]
    partial class addUserRoleToAdmin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodAPI.DAL.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCreated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Dessert",
                            DateCreated = new DateTime(2022, 9, 17, 22, 6, 59, 279, DateTimeKind.Local).AddTicks(5878),
                            ImageCategory = "/images/cake.jpg",
                            UserCreated = "Adnan"
                        });
                });

            modelBuilder.Entity("FoodAPI.DAL.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TypeFood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("availabilty")
                        .HasColumnType("int");

                    b.Property<string>("cuisine")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "From its medieval origins to the digital era, learn ",
                            ImageUrl = "/images/cake.jpg",
                            Name = "cake1",
                            Price = 100m,
                            TypeFood = "sweet",
                            UserCreated = "adnan",
                            availabilty = 5,
                            cuisine = "italian"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "From its medieval origins to the digital era, learn ",
                            ImageUrl = "/images/cake.jpg",
                            Name = "cake2",
                            Price = 100m,
                            TypeFood = "sweet",
                            UserCreated = "adnan",
                            availabilty = 5,
                            cuisine = "italian"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "From its medieval origins to the digital era, learn ",
                            ImageUrl = "/images/cake.jpg",
                            Name = "cake3",
                            Price = 100m,
                            TypeFood = "sweet",
                            UserCreated = "adnan",
                            availabilty = 5,
                            cuisine = "italian"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 9, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "From its medieval origins to the digital era, learn ",
                            ImageUrl = "/images/cake.jpg",
                            Name = "cake4",
                            Price = 100m,
                            TypeFood = "sweet",
                            UserCreated = "adnan",
                            availabilty = 5,
                            cuisine = "italian"
                        });
                });

            modelBuilder.Entity("FoodAPI.DAL.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "afb56f6c-fe49-4909-a208-cf98d79f2e3f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0028da81-d242-4ebd-8472-4d6d9817cdd1",
                            Email = "admin@hotmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@HOTMAIL.COM",
                            NormalizedUserName = "ADMIN@HOTMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELTR+AhxOSZoqzGQh+cYv7X5GP8yRLd2L3zj9Rp6nr9vTos24RXpZC75qPNwBGs9MQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b8029325-17ff-425a-88d4-7c292b41819c",
                            TwoFactorEnabled = false,
                            UserName = "admin@hotmail.com"
                        },
                        new
                        {
                            Id = "35a05032-f96a-434a-bb49-d87fe15c9b6d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cf63ff0c-444a-4ae2-9928-d71e831106a5",
                            Email = "adnan@hotmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADNAN@HOTMAIL.COM",
                            NormalizedUserName = "ADNAN@HOTMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEA2Bz16sv9oWxHLkW1n+/GrCjRp/uh5GiTwgzrKjys2rQfgLPZ/rqRNWWqa0jXnsRQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fd825ac9-35dc-4674-b718-e9a51f4937d3",
                            TwoFactorEnabled = false,
                            UserName = "adnan@hotmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "6986c43a-78ff-4825-a1d7-da634259e913",
                            ConcurrencyStamp = "10698375-4b6c-4b45-9d78-d7c663acf0cb",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "cf8e5237-4dee-4db4-b26e-1948acff19af",
                            ConcurrencyStamp = "1a78a70e-ef36-4c35-9f66-f088c26362e4",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "afb56f6c-fe49-4909-a208-cf98d79f2e3f",
                            RoleId = "6986c43a-78ff-4825-a1d7-da634259e913"
                        },
                        new
                        {
                            UserId = "afb56f6c-fe49-4909-a208-cf98d79f2e3f",
                            RoleId = "cf8e5237-4dee-4db4-b26e-1948acff19af"
                        },
                        new
                        {
                            UserId = "35a05032-f96a-434a-bb49-d87fe15c9b6d",
                            RoleId = "cf8e5237-4dee-4db4-b26e-1948acff19af"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FoodAPI.DAL.Entities.Product", b =>
                {
                    b.HasOne("FoodAPI.DAL.Entities.Category", "Category")
                        .WithMany("ProductList")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FoodAPI.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FoodAPI.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodAPI.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FoodAPI.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodAPI.DAL.Entities.Category", b =>
                {
                    b.Navigation("ProductList");
                });
#pragma warning restore 612, 618
        }
    }
}
