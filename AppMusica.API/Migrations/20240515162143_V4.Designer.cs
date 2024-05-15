﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppMusica.API.Migrations
{
    [DbContext(typeof(DbContext))]
    [Migration("20240515162143_V4")]
    partial class V4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppMusica.Entidades.Instrumento_musical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Descuento")
                        .HasColumnType("float");

                    b.Property<int>("IdTipo_instrumento")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<int?>("Tipo_InstrumentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Tipo_InstrumentoId");

                    b.ToTable("Instrumentos_musicales");
                });

            modelBuilder.Entity("AppMusica.Entidades.Tipo_instrumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipo_instrumentos");
                });

            modelBuilder.Entity("AppMusica.Entidades.Instrumento_musical", b =>
                {
                    b.HasOne("AppMusica.Entidades.Tipo_instrumento", "Tipo_Instrumento")
                        .WithMany("Instrumentos")
                        .HasForeignKey("Tipo_InstrumentoId");

                    b.Navigation("Tipo_Instrumento");
                });

            modelBuilder.Entity("AppMusica.Entidades.Tipo_instrumento", b =>
                {
                    b.Navigation("Instrumentos");
                });
#pragma warning restore 612, 618
        }
    }
}
