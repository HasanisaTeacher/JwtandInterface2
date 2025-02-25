﻿// <auto-generated />
using System;
using JwtandInterface2.Controllers.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JwtandInterface2.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JwtandInterface2.Controllers.Models.UserDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("JwtandInterface2.Controllers.Models.UserInfoDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserDtoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserDtoId")
                        .IsUnique();

                    b.ToTable("UserInfos");
                });

            modelBuilder.Entity("JwtandInterface2.Models.RoleDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("RoleDtoUserInfoDto", b =>
                {
                    b.Property<int>("RoleDtosId")
                        .HasColumnType("int");

                    b.Property<int>("UserInfoDtosId")
                        .HasColumnType("int");

                    b.HasKey("RoleDtosId", "UserInfoDtosId");

                    b.HasIndex("UserInfoDtosId");

                    b.ToTable("RoleDtoUserInfoDto");
                });

            modelBuilder.Entity("JwtandInterface2.Controllers.Models.UserInfoDto", b =>
                {
                    b.HasOne("JwtandInterface2.Controllers.Models.UserDto", "UserDto")
                        .WithOne("UserInfo")
                        .HasForeignKey("JwtandInterface2.Controllers.Models.UserInfoDto", "UserDtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDto");
                });

            modelBuilder.Entity("RoleDtoUserInfoDto", b =>
                {
                    b.HasOne("JwtandInterface2.Models.RoleDto", null)
                        .WithMany()
                        .HasForeignKey("RoleDtosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JwtandInterface2.Controllers.Models.UserInfoDto", null)
                        .WithMany()
                        .HasForeignKey("UserInfoDtosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JwtandInterface2.Controllers.Models.UserDto", b =>
                {
                    b.Navigation("UserInfo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
