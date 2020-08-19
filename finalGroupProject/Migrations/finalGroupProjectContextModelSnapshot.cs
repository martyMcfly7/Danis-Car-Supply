﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalGroupProject.Models;

namespace finalGroupProject.Migrations
{
    [DbContext(typeof(finalGroupProjectContext))]
    partial class finalGroupProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085");

            modelBuilder.Entity("finalGroupProject.Models.CarSupply", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("fName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("lName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("state")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("zip")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("CarSupply");
                });
#pragma warning restore 612, 618
        }
    }
}
