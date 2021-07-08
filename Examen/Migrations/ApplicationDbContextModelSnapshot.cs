﻿// <auto-generated />
using Examen.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Examen.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Examen.Models.Prospecto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellidoM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellidoP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("calle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("codigoPostal")
                        .HasColumnType("int");

                    b.Property<string>("colonia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<string>("observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rfc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Prospecto");
                });
#pragma warning restore 612, 618
        }
    }
}