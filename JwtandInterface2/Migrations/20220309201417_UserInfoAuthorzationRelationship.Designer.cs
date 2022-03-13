﻿// <auto-generated />
using System;
using JwtandInterface2.Controllers.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JwtandInterface2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220309201417_UserInfoAuthorzationRelationship")]
    partial class UserInfoAuthorzationRelationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("UserDtos");
                });

            modelBuilder.Entity("JwtandInterface2.Controllers.Models.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorizationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserDtoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserDtoId")
                        .IsUnique();

                    b.ToTable("UserInfos");
                });

            modelBuilder.Entity("JwtandInterface2.Models.Authorization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserInfoId");

                    b.ToTable("Authorizations");
                });

            modelBuilder.Entity("JwtandInterface2.Controllers.Models.UserInfo", b =>
                {
                    b.HasOne("JwtandInterface2.Controllers.Models.UserDto", "UserDto")
                        .WithOne("UserInfo")
                        .HasForeignKey("JwtandInterface2.Controllers.Models.UserInfo", "UserDtoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDto");
                });

            modelBuilder.Entity("JwtandInterface2.Models.Authorization", b =>
                {
                    b.HasOne("JwtandInterface2.Controllers.Models.UserInfo", "UserInfo")
                        .WithMany("Authorization")
                        .HasForeignKey("UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("JwtandInterface2.Controllers.Models.UserDto", b =>
                {
                    b.Navigation("UserInfo")
                        .IsRequired();
                });

            modelBuilder.Entity("JwtandInterface2.Controllers.Models.UserInfo", b =>
                {
                    b.Navigation("Authorization");
                });
#pragma warning restore 612, 618
        }
    }
}
