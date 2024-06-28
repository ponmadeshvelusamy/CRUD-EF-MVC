﻿// <auto-generated />
using EFAppLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFAppLibrary.Migrations
{
    [DbContext(typeof(ConstituteEFW))]
    partial class ConstituteEFWModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFAppLibrary.Model.Constitutemodel", b =>
                {
                    b.Property<long>("Constituteid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Constituteid"), 1L, 1);

                    b.Property<string>("Constitutename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Totalofconstitute")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Totaloffemale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Totalofmale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Constituteid");

                    b.ToTable("Constitutemodel");
                });
#pragma warning restore 612, 618
        }
    }
}
