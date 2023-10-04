﻿// <auto-generated />
using System;
using Administration.Infra.DataBase.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Administration.Infra.DataBase.EntityFramework.Migrations
{
    [DbContext(typeof(AdministrationDbContext))]
    [Migration("20231004193353_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.1.23419.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Administration.Domain.Restaurants.Models.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AdministrativeEmail")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("AdministrativePhone")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("CommercialEmail")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("CommercialPhone")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("PrimaryContact")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("Administration.Domain.Restaurants.Models.Restaurant", b =>
                {
                    b.OwnsOne("BuildingBlock.Domain.ValueObjects.Address.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("RestaurantId")
                                .HasColumnType("uuid");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("City");

                            b1.Property<string>("Complement")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("Complement");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("Number");

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("State");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("Street");

                            b1.Property<string>("ZIPCode")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("ZIPCode");

                            b1.HasKey("RestaurantId");

                            b1.ToTable("Restaurants");

                            b1.WithOwner()
                                .HasForeignKey("RestaurantId");
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
