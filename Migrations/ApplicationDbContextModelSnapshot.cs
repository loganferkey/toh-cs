﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TOHFerkey.Data;

#nullable disable

namespace TOHFerkey.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TOHFerkey.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Heroes");

                    b.HasData(
                        new
                        {
                            Id = 12,
                            Name = "Dr. Nice"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Bombasto"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Celeritas"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Magneta"
                        },
                        new
                        {
                            Id = 16,
                            Name = "RubberMan"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Dynama"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Dr. IQ"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Magma"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Tornado"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
