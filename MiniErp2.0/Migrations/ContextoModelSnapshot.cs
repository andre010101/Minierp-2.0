﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniErp2;

#nullable disable

namespace MiniErp2._0.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MiniErp2.DataModels.Clientes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("MiniErp2.DataModels.Fornecedores", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("fornecedor");
                });

            modelBuilder.Entity("MiniErp2.DataModels.Notas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Nfnumero")
                        .HasColumnType("int");

                    b.Property<string>("infoNota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("total")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("notas");
                });

            modelBuilder.Entity("MiniErp2.DataModels.Pedido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("clienteid")
                        .HasColumnType("int");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<int>("notaid")
                        .HasColumnType("int");

                    b.Property<int>("preco")
                        .HasColumnType("int");

                    b.Property<int>("produtosid")
                        .HasColumnType("int");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("clienteid");

                    b.HasIndex("notaid");

                    b.HasIndex("produtosid");

                    b.ToTable("pedido");
                });

            modelBuilder.Entity("MiniErp2.DataModels.Produtos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Fornecedoresid")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("preco")
                        .HasColumnType("int");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Fornecedoresid");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("MiniErp2.DataModels.Pedido", b =>
                {
                    b.HasOne("MiniErp2.DataModels.Clientes", "cliente")
                        .WithMany("pedidos")
                        .HasForeignKey("clienteid")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("MiniErp2.DataModels.Notas", "nota")
                        .WithMany("pedidos")
                        .HasForeignKey("notaid")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("MiniErp2.DataModels.Produtos", "produtos")
                        .WithMany("pedidos")
                        .HasForeignKey("produtosid")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("cliente");

                    b.Navigation("nota");

                    b.Navigation("produtos");
                });

            modelBuilder.Entity("MiniErp2.DataModels.Produtos", b =>
                {
                    b.HasOne("MiniErp2.DataModels.Fornecedores", null)
                        .WithMany("produto")
                        .HasForeignKey("Fornecedoresid");
                });

            modelBuilder.Entity("MiniErp2.DataModels.Clientes", b =>
                {
                    b.Navigation("pedidos");
                });

            modelBuilder.Entity("MiniErp2.DataModels.Fornecedores", b =>
                {
                    b.Navigation("produto");
                });

            modelBuilder.Entity("MiniErp2.DataModels.Notas", b =>
                {
                    b.Navigation("pedidos");
                });

            modelBuilder.Entity("MiniErp2.DataModels.Produtos", b =>
                {
                    b.Navigation("pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
