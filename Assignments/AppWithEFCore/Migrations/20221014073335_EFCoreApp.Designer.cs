﻿// <auto-generated />
using AppWithEFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppWithEFCore.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20221014073335_EFCoreApp")]
    partial class EFCoreApp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppWithEFCore.Models.AWB", b =>
                {
                    b.Property<int>("AWBNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AWBNumber"), 1L, 1);

                    b.Property<string>("Reciever")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AWBNumber");

                    b.ToTable("AWBs");
                });
#pragma warning restore 612, 618
        }
    }
}
