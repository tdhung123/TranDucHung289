﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace TranDucHung289.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    [Migration("20230104011531_CompanyTDH289")]
    partial class CompanyTDH289
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("TranDucHung289.Models.CompanyTDH289", b =>
                {
                    b.Property<string>("CompanyId")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("CompanyId");

                    b.ToTable("CompanyTDH289");
                });
#pragma warning restore 612, 618
        }
    }
}