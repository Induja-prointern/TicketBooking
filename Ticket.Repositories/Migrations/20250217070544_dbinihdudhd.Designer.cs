﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ticket.Repositories;

#nullable disable

namespace Ticket.Repositories.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250217070544_dbinihdudhd")]
    partial class dbinihdudhd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ticket.Repositories.Entities.Booking", b =>
                {
                    b.Property<Guid>("bookingid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("bookingdate")
                        .HasColumnType("int");

                    b.Property<int>("tickets")
                        .HasColumnType("int");

                    b.HasKey("bookingid");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Ticket.Repositories.Entities.Bus", b =>
                {
                    b.Property<Guid>("busid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("bname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("busdrivername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("busid");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("Ticket.Repositories.Entities.Payment", b =>
                {
                    b.Property<int>("paymnetid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("paymnetid"));

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("paymnetid");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Ticket.Repositories.Entities.TravelTicket", b =>
                {
                    b.Property<int>("ticketid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ticketid"));

                    b.Property<string>("seatnumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ticketid");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Ticket.Repositories.Entities.User", b =>
                {
                    b.Property<Guid>("uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("uid");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
