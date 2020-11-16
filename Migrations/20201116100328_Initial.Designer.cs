﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_rpg.Data;

namespace dotnet_rpg.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201116100328_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dotnet_rpg.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<int>("Defeats")
                        .HasColumnType("int");

                    b.Property<int>("Defense")
                        .HasColumnType("int");

                    b.Property<int>("Fights")
                        .HasColumnType("int");

                    b.Property<int>("HitPoints")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Victories")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Class = 1,
                            Defeats = 0,
                            Defense = 10,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 10,
                            Name = "Frodo",
                            Strength = 15,
                            UserId = 1,
                            Victories = 0
                        },
                        new
                        {
                            Id = 2,
                            Class = 2,
                            Defeats = 0,
                            Defense = 5,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 20,
                            Name = "Raistlin",
                            Strength = 5,
                            UserId = 2,
                            Victories = 0
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.CharacterSkill", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("CharacterSkills");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            SkillId = 2
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 1
                        },
                        new
                        {
                            CharacterId = 2,
                            SkillId = 3
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Damage = 30,
                            Name = "Fireball"
                        },
                        new
                        {
                            Id = 2,
                            Damage = 20,
                            Name = "Frenzy"
                        },
                        new
                        {
                            Id = 3,
                            Damage = 50,
                            Name = "Blizzard"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Player");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 154, 30, 12, 167, 43, 250, 53, 83, 219, 52, 10, 199, 98, 100, 187, 149, 73, 171, 248, 217, 40, 245, 134, 237, 108, 176, 96, 148, 240, 139, 123, 131, 138, 92, 209, 204, 128, 92, 41, 159, 26, 224, 49, 94, 101, 105, 48, 61, 115, 244, 73, 120, 31, 55, 10, 88, 136, 189, 247, 103, 197, 229, 132, 69 },
                            PasswordSalt = new byte[] { 55, 111, 75, 111, 86, 4, 67, 83, 15, 140, 147, 186, 120, 140, 118, 255, 0, 230, 36, 150, 121, 165, 248, 45, 163, 51, 55, 246, 166, 93, 179, 165, 111, 208, 105, 118, 232, 174, 228, 13, 177, 101, 127, 111, 52, 172, 225, 188, 86, 48, 33, 29, 175, 243, 251, 185, 26, 140, 164, 228, 102, 42, 44, 137, 110, 227, 246, 157, 14, 122, 11, 162, 71, 222, 92, 126, 163, 1, 89, 189, 31, 197, 38, 147, 217, 15, 2, 177, 108, 11, 217, 105, 98, 211, 21, 126, 144, 160, 167, 203, 119, 51, 183, 225, 0, 183, 226, 198, 77, 27, 156, 40, 105, 188, 220, 25, 42, 67, 161, 126, 62, 232, 71, 44, 55, 22, 131, 247 },
                            Username = "User1"
                        },
                        new
                        {
                            Id = 2,
                            PasswordHash = new byte[] { 154, 30, 12, 167, 43, 250, 53, 83, 219, 52, 10, 199, 98, 100, 187, 149, 73, 171, 248, 217, 40, 245, 134, 237, 108, 176, 96, 148, 240, 139, 123, 131, 138, 92, 209, 204, 128, 92, 41, 159, 26, 224, 49, 94, 101, 105, 48, 61, 115, 244, 73, 120, 31, 55, 10, 88, 136, 189, 247, 103, 197, 229, 132, 69 },
                            PasswordSalt = new byte[] { 55, 111, 75, 111, 86, 4, 67, 83, 15, 140, 147, 186, 120, 140, 118, 255, 0, 230, 36, 150, 121, 165, 248, 45, 163, 51, 55, 246, 166, 93, 179, 165, 111, 208, 105, 118, 232, 174, 228, 13, 177, 101, 127, 111, 52, 172, 225, 188, 86, 48, 33, 29, 175, 243, 251, 185, 26, 140, 164, 228, 102, 42, 44, 137, 110, 227, 246, 157, 14, 122, 11, 162, 71, 222, 92, 126, 163, 1, 89, 189, 31, 197, 38, 147, 217, 15, 2, 177, 108, 11, 217, 105, 98, 211, 21, 126, 144, 160, 167, 203, 119, 51, 183, 225, 0, 183, 226, 198, 77, 27, 156, 40, 105, 188, 220, 25, 42, 67, 161, 126, 62, 232, 71, 44, 55, 22, 131, 247 },
                            Username = "User2"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Weapons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterId = 1,
                            Damage = 20,
                            Name = "The Master Sword"
                        },
                        new
                        {
                            Id = 2,
                            CharacterId = 2,
                            Damage = 5,
                            Name = "Crystal Wand"
                        });
                });

            modelBuilder.Entity("dotnet_rpg.Models.Character", b =>
                {
                    b.HasOne("dotnet_rpg.Models.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dotnet_rpg.Models.CharacterSkill", b =>
                {
                    b.HasOne("dotnet_rpg.Models.Character", "Character")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet_rpg.Models.Skill", "Skill")
                        .WithMany("CharacterSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dotnet_rpg.Models.Weapon", b =>
                {
                    b.HasOne("dotnet_rpg.Models.Character", "Character")
                        .WithOne("Weapon")
                        .HasForeignKey("dotnet_rpg.Models.Weapon", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}