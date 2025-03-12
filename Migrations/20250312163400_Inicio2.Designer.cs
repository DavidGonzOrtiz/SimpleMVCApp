﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleMVCApp.Models;

#nullable disable

namespace SimpleMVCApp.Migrations
{
    [DbContext(typeof(PersonaDataContext))]
    [Migration("20250312163400_Inicio2")]
    partial class Inicio2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SimpleMVCApp.Models.Persona", b =>
                {
                    b.Property<int>("PersonaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonaID"));

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonaID");

                    b.ToTable("personas");

                    b.HasData(
                        new
                        {
                            PersonaID = 1,
                            Apellidos = "Pérez",
                            Edad = 30,
                            Nombre = "Juan"
                        },
                        new
                        {
                            PersonaID = 2,
                            Apellidos = "González",
                            Edad = 25,
                            Nombre = "María"
                        },
                        new
                        {
                            PersonaID = 3,
                            Apellidos = "Ramírez",
                            Edad = 40,
                            Nombre = "Carlos"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
