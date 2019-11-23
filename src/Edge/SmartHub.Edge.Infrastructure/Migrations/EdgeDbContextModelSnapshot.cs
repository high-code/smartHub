﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SmartHub.Edge.Infrastructure;

namespace SmartHub.Edge.Infrastructure.Migrations
{
    [DbContext(typeof(EdgeDbContext))]
    partial class EdgeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SmartHub.Edge.Infrastructure.Entities.Measurement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("DeviceId")
                        .HasColumnName("device_id");

                    b.Property<DateTime>("DtSent")
                        .HasColumnName("dt_sent");

                    b.Property<int>("Type")
                        .HasColumnName("type");

                    b.Property<double>("Value")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_measurements");

                    b.ToTable("measurements");
                });
#pragma warning restore 612, 618
        }
    }
}
