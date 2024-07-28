﻿// <auto-generated />
using System;
using App.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace App.Database.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240728021145_InitialDb")]
    partial class InitialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("App.Domain.UserEntity", b =>
                {
                    b.Property<Guid>("id")
                        .HasColumnType("uuid")
                        .HasColumnOrder(1)
                        .HasComment("คีร์ของข้อมูล");

                    b.Property<DateTime?>("created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnOrder(200)
                        .HasComment("เวลาสร้าง");

                    b.Property<string>("email")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnOrder(5)
                        .HasComment("อีเมล/username");

                    b.Property<string>("fullname")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnOrder(3)
                        .HasComment("ชื่อเต็ม");

                    b.Property<bool?>("isActive")
                        .HasColumnType("boolean")
                        .HasColumnOrder(202)
                        .HasComment("ใช้งานได้หรือไม่");

                    b.Property<string>("nickname")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnOrder(2)
                        .HasComment("ชื่อเรียก");

                    b.Property<string>("password")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnOrder(6)
                        .HasComment("รหัสผ่าน");

                    b.Property<string>("phone")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnOrder(4)
                        .HasComment("โทรศัพท์");

                    b.Property<DateTime?>("updated")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnOrder(201)
                        .HasComment("เวลาปรับปรุงล่าสุด");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
