﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeliculasApi;

#nullable disable

namespace PeliculasApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230705112619_Data")]
    partial class Data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PeliculasApi.Entidades.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("Actores");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            FechaNacimiento = "1/17/1962",
                            Nombre = "Jim Carrey"
                        },
                        new
                        {
                            Id = 6,
                            FechaNacimiento = "4/4/1965",
                            Nombre = "Robert Downey Jr."
                        },
                        new
                        {
                            Id = 7,
                            FechaNacimiento = "6/13/1981",
                            Nombre = "Chris Evans"
                        });
                });

            modelBuilder.Entity("PeliculasApi.Entidades.Genero", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("id");

                    b.ToTable("Generos");

                    b.HasData(
                        new
                        {
                            id = 4,
                            Nombre = "Aventura"
                        },
                        new
                        {
                            id = 5,
                            Nombre = "Animación"
                        },
                        new
                        {
                            id = 6,
                            Nombre = "Suspenso"
                        },
                        new
                        {
                            id = 7,
                            Nombre = "Romance"
                        });
                });

            modelBuilder.Entity("PeliculasApi.Entidades.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EnCines")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("datetime2");

                    b.Property<string>("Poster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            EnCines = true,
                            FechaEstreno = new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Avengers: Endgame"
                        },
                        new
                        {
                            Id = 3,
                            EnCines = false,
                            FechaEstreno = new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Avengers: Infinity Wars"
                        },
                        new
                        {
                            Id = 4,
                            EnCines = false,
                            FechaEstreno = new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Sonic the Hedgehog"
                        },
                        new
                        {
                            Id = 5,
                            EnCines = false,
                            FechaEstreno = new DateTime(2020, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Emma"
                        },
                        new
                        {
                            Id = 6,
                            EnCines = false,
                            FechaEstreno = new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Titulo = "Wonder Woman 1984"
                        });
                });

            modelBuilder.Entity("PeliculasApi.Entidades.PeliculasActores", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Personaje")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("PeliculasActores");

                    b.HasData(
                        new
                        {
                            ActorId = 6,
                            PeliculaId = 2,
                            Orden = 1,
                            Personaje = "Tony Stark"
                        },
                        new
                        {
                            ActorId = 7,
                            PeliculaId = 2,
                            Orden = 2,
                            Personaje = "Steve Rogers"
                        },
                        new
                        {
                            ActorId = 6,
                            PeliculaId = 3,
                            Orden = 1,
                            Personaje = "Tony Stark"
                        },
                        new
                        {
                            ActorId = 7,
                            PeliculaId = 3,
                            Orden = 2,
                            Personaje = "Steve Rogers"
                        },
                        new
                        {
                            ActorId = 5,
                            PeliculaId = 4,
                            Orden = 1,
                            Personaje = "Dr. Ivo Robotnik"
                        });
                });

            modelBuilder.Entity("PeliculasApi.Entidades.PeliculasGeneros", b =>
                {
                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("GeneroId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("PeliculasGeneros");

                    b.HasData(
                        new
                        {
                            GeneroId = 6,
                            PeliculaId = 2
                        },
                        new
                        {
                            GeneroId = 4,
                            PeliculaId = 2
                        },
                        new
                        {
                            GeneroId = 6,
                            PeliculaId = 3
                        },
                        new
                        {
                            GeneroId = 4,
                            PeliculaId = 3
                        },
                        new
                        {
                            GeneroId = 4,
                            PeliculaId = 4
                        },
                        new
                        {
                            GeneroId = 6,
                            PeliculaId = 5
                        },
                        new
                        {
                            GeneroId = 7,
                            PeliculaId = 5
                        },
                        new
                        {
                            GeneroId = 6,
                            PeliculaId = 6
                        },
                        new
                        {
                            GeneroId = 4,
                            PeliculaId = 6
                        });
                });

            modelBuilder.Entity("PeliculasApi.Entidades.PeliculasActores", b =>
                {
                    b.HasOne("PeliculasApi.Entidades.Actor", "Actor")
                        .WithMany("PeliculasActores")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeliculasApi.Entidades.Pelicula", "Pelicula")
                        .WithMany("PeliculasActores")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("PeliculasApi.Entidades.PeliculasGeneros", b =>
                {
                    b.HasOne("PeliculasApi.Entidades.Genero", "Genero")
                        .WithMany("PeliculasGeneros")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeliculasApi.Entidades.Pelicula", "Pelicula")
                        .WithMany("PeliculasGeneros")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("PeliculasApi.Entidades.Actor", b =>
                {
                    b.Navigation("PeliculasActores");
                });

            modelBuilder.Entity("PeliculasApi.Entidades.Genero", b =>
                {
                    b.Navigation("PeliculasGeneros");
                });

            modelBuilder.Entity("PeliculasApi.Entidades.Pelicula", b =>
                {
                    b.Navigation("PeliculasActores");

                    b.Navigation("PeliculasGeneros");
                });
#pragma warning restore 612, 618
        }
    }
}