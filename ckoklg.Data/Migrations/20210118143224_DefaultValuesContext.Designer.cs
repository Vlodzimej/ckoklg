﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ckoklg.Data.Context;

namespace Ckoklg.Data.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20210118143224_DefaultValuesContext")]
    partial class DefaultValuesContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Ckoklg.Domain.Entities.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("CreatedUser")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Sequence")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedData")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UpdatedUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Modules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedUser = 0,
                            Icon = "dashboard.png",
                            IsActive = true,
                            Name = "Dashboard",
                            Sequence = 1,
                            URL = "dashboard",
                            UpdatedUser = 0
                        });
                });

            modelBuilder.Entity("Ckoklg.Domain.Entities.ModuleProfile", b =>
                {
                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("ModuleId", "ProfileId");

                    b.HasIndex("ProfileId");

                    b.ToTable("ModuleProfiles");

                    b.HasData(
                        new
                        {
                            ModuleId = 1,
                            ProfileId = 1
                        },
                        new
                        {
                            ModuleId = 1,
                            ProfileId = 2
                        });
                });

            modelBuilder.Entity("Ckoklg.Domain.Entities.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("CreatedUser")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsDefault")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedData")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UpdatedUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedUser = 0,
                            IsActive = true,
                            IsDefault = false,
                            Name = "Admin",
                            UpdatedUser = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedUser = 0,
                            IsActive = true,
                            IsDefault = false,
                            Name = "User",
                            UpdatedUser = 0
                        });
                });

            modelBuilder.Entity("Ckoklg.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("CreatedUser")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsAuthorised")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedData")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UpdatedUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 1, 18, 14, 32, 23, 775, DateTimeKind.Local).AddTicks(6768),
                            CreatedUser = 1,
                            Email = "admin@Ckoklg.com",
                            IsActive = true,
                            IsAuthorised = true,
                            Name = "Admin",
                            Password = "8D66A53A381493BEC08DA23CEF5A43767F20A42C",
                            ProfileId = 1,
                            UpdatedUser = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 1, 18, 14, 32, 23, 778, DateTimeKind.Local).AddTicks(3754),
                            CreatedUser = 1,
                            Email = "user@Ckoklg.com",
                            IsActive = true,
                            IsAuthorised = true,
                            Name = "User",
                            Password = "8D66A53A381493BEC08DA23CEF5A43767F20A42C",
                            ProfileId = 2,
                            UpdatedUser = 0
                        });
                });

            modelBuilder.Entity("Ckoklg.Domain.Entities.ModuleProfile", b =>
                {
                    b.HasOne("Ckoklg.Domain.Entities.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Ckoklg.Domain.Entities.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Module");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Ckoklg.Domain.Entities.User", b =>
                {
                    b.HasOne("Ckoklg.Domain.Entities.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Profile");
                });
#pragma warning restore 612, 618
        }
    }
}