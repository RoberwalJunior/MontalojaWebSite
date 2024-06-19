﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MontalojaWebSite.Bibliotecas.Infraestrutura.Dados;

#nullable disable

namespace MontalojaWebSite.Bibliotecas.Infraestrutura.Migrations
{
    [DbContext(typeof(MontalojaWebSiteContext))]
    partial class MontalojaWebSiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MontalojaWebSite.Bibliotecas.Dominio.Modelos.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("MontalojaWebSite.Bibliotecas.Dominio.Modelos.Loja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Lojas");
                });

            modelBuilder.Entity("MontalojaWebSite.Bibliotecas.Dominio.Modelos.Movel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LojaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LojaId");

                    b.ToTable("Moveis");
                });

            modelBuilder.Entity("MontalojaWebSite.Bibliotecas.Dominio.Modelos.Loja", b =>
                {
                    b.HasOne("MontalojaWebSite.Bibliotecas.Dominio.Modelos.Cliente", "Cliente")
                        .WithMany("Lojas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("MontalojaWebSite.Bibliotecas.Dominio.Modelos.Movel", b =>
                {
                    b.HasOne("MontalojaWebSite.Bibliotecas.Dominio.Modelos.Loja", "Loja")
                        .WithMany("Moveis")
                        .HasForeignKey("LojaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loja");
                });

            modelBuilder.Entity("MontalojaWebSite.Bibliotecas.Dominio.Modelos.Cliente", b =>
                {
                    b.Navigation("Lojas");
                });

            modelBuilder.Entity("MontalojaWebSite.Bibliotecas.Dominio.Modelos.Loja", b =>
                {
                    b.Navigation("Moveis");
                });
#pragma warning restore 612, 618
        }
    }
}
