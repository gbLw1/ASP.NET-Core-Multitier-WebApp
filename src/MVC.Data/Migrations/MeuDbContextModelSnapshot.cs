﻿// <auto-generated />
using System;
using MVC.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC.Data.Migrations
{
    [DbContext(typeof(MeuDbContext))]
    partial class MeuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVC.Business.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Complemento")
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR(250)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR(50)");

                    b.Property<Guid>("FornecedorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId")
                        .IsUnique();

                    b.ToTable("Enderecos", (string)null);
                });

            modelBuilder.Entity("MVC.Business.Models.Fornecedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR(14)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<int>("TipoFornecedor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores", (string)null);
                });

            modelBuilder.Entity("MVC.Business.Models.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR(1000)");

                    b.Property<Guid>("FornecedorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("DECIMAL(15,2)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produtos", (string)null);
                });

            modelBuilder.Entity("MVC.Business.Models.Endereco", b =>
                {
                    b.HasOne("MVC.Business.Models.Fornecedor", "Fornecedor")
                        .WithOne("Endereco")
                        .HasForeignKey("MVC.Business.Models.Endereco", "FornecedorId")
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("MVC.Business.Models.Produto", b =>
                {
                    b.HasOne("MVC.Business.Models.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId")
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("MVC.Business.Models.Fornecedor", b =>
                {
                    b.Navigation("Endereco")
                        .IsRequired();

                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
