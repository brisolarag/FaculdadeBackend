﻿// <auto-generated />
using FaculdadeApp_Backend.src.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FaculdadeApp_Backend.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240902145428_setup")]
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    partial class setup
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FaculdadeApp_Backend.src.pieces.cadeiras.models.Cadeira", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Creditos")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PodeFaltar")
                        .HasColumnType("int");

                    b.Property<int>("QtdAulas")
                        .HasColumnType("int");

                    b.Property<int>("SemestreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SemestreId");

                    b.ToTable("Cadeiras");
                });

            modelBuilder.Entity("FaculdadeApp_Backend.src.pieces.semestres.models.Semestre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Metade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Semestres");
                });

            modelBuilder.Entity("FaculdadeApp_Backend.src.pieces.cadeiras.models.Cadeira", b =>
                {
                    b.HasOne("FaculdadeApp_Backend.src.pieces.semestres.models.Semestre", "Semestre")
                        .WithMany("Cadeiras")
                        .HasForeignKey("SemestreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Semestre");
                });

            modelBuilder.Entity("FaculdadeApp_Backend.src.pieces.semestres.models.Semestre", b =>
                {
                    b.Navigation("Cadeiras");
                });
#pragma warning restore 612, 618
        }
    }
}
