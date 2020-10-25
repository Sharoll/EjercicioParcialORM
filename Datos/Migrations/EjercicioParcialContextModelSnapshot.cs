﻿// <auto-generated />
using System;
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(EjercicioParcialContext))]
    partial class EjercicioParcialContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entidad.Persona", b =>
                {
                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("Date");

                    b.Property<string>("Modalidad")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("valorApoyo")
                        .HasColumnType("decimal(18,0)");

                    b.HasKey("Identificacion");

                    b.ToTable("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
