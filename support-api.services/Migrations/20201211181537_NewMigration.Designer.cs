﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SupportAPI.Services.Data;

namespace SupportAPI.Services.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201211181537_NewMigration")]
    partial class NewMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SupportAPI.Services.Models.Organization", b =>
                {
                    b.Property<int>("IdOrganization")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("IdProfile")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.HasKey("IdOrganization");

                    b.HasIndex("IdProfile")
                        .IsUnique();

                    b.ToTable("Organization");
                });

            modelBuilder.Entity("SupportAPI.Services.Models.Profile", b =>
                {
                    b.Property<int>("IdProfile")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("ConnectionsWithMeter")
                        .HasColumnType("integer");

                    b.Property<int>("ConnectionsWithoutMeter")
                        .HasColumnType("integer");

                    b.Property<string>("Department")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("Employes")
                        .HasColumnType("integer");

                    b.Property<string>("Formation")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("Latrines")
                        .HasColumnType("integer");

                    b.Property<string>("Municipality")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Phone")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("Professionals")
                        .HasColumnType("integer");

                    b.Property<string>("Province")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("PublicPools")
                        .HasColumnType("integer");

                    b.Property<string>("ServiceContinuity")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("WaterConnections")
                        .HasColumnType("integer");

                    b.HasKey("IdProfile");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("SupportAPI.Services.Models.SupportApiUser", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("IdOrganization")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.HasKey("Username");

                    b.HasIndex("IdOrganization");

                    b.ToTable("SupportApiUser");
                });

            modelBuilder.Entity("SupportAPI.Services.Models.SupportApiUser_UserKobo", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("character varying(500)");

                    b.HasKey("Name", "Username");

                    b.HasIndex("Username");

                    b.ToTable("SupportApiUser_UserKobo");
                });

            modelBuilder.Entity("SupportAPI.Services.Models.UserKobo", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.HasKey("Name");

                    b.ToTable("UserKobo");
                });

            modelBuilder.Entity("SupportAPI.Services.Models.Organization", b =>
                {
                    b.HasOne("SupportAPI.Services.Models.Profile", "Profile")
                        .WithOne("Organization")
                        .HasForeignKey("SupportAPI.Services.Models.Organization", "IdProfile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SupportAPI.Services.Models.SupportApiUser", b =>
                {
                    b.HasOne("SupportAPI.Services.Models.Organization", "Organization")
                        .WithMany("SupportApiUsers")
                        .HasForeignKey("IdOrganization")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SupportAPI.Services.Models.SupportApiUser_UserKobo", b =>
                {
                    b.HasOne("SupportAPI.Services.Models.UserKobo", "UserKobo")
                        .WithMany("SupportApiUser_UserKobo")
                        .HasForeignKey("Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SupportAPI.Services.Models.SupportApiUser", "SupportApiUser")
                        .WithMany("SupportApiUser_UserKobo")
                        .HasForeignKey("Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
