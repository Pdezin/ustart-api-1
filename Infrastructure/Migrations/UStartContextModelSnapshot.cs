﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UStart.Infrastructure.Context;

namespace UStart.Infrastructure.Migrations
{
    [DbContext(typeof(UStartContext))]
    partial class UStartContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("UStart.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Bairro")
                        .HasColumnType("text")
                        .HasColumnName("bairro");

                    b.Property<string>("CEP")
                        .HasColumnType("text")
                        .HasColumnName("cep");

                    b.Property<string>("CNPJ")
                        .HasColumnType("text")
                        .HasColumnName("cnpj");

                    b.Property<string>("CPF")
                        .HasColumnType("text")
                        .HasColumnName("cpf");

                    b.Property<string>("CidadeId")
                        .HasColumnType("text")
                        .HasColumnName("cidade_id");

                    b.Property<string>("CidadeNome")
                        .HasColumnType("text")
                        .HasColumnName("cidade_nome");

                    b.Property<string>("CodigoExterno")
                        .HasColumnType("text")
                        .HasColumnName("codigo_externo");

                    b.Property<string>("Complemento")
                        .HasColumnType("text")
                        .HasColumnName("complemento");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("EstadoId")
                        .HasColumnType("text")
                        .HasColumnName("estado_id");

                    b.Property<string>("Fone")
                        .HasColumnType("text")
                        .HasColumnName("fone");

                    b.Property<decimal>("LimiteDeCredito")
                        .HasColumnType("numeric")
                        .HasColumnName("limite_de_credito");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("Numero")
                        .HasColumnType("text")
                        .HasColumnName("numero");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("text")
                        .HasColumnName("razao_social");

                    b.Property<string>("Rua")
                        .HasColumnType("text")
                        .HasColumnName("rua");

                    b.HasKey("Id")
                        .HasName("pk_clientes");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("UStart.Domain.Entities.GrupoProduto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("CodigoExterno")
                        .HasColumnType("text")
                        .HasColumnName("codigo_externo");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.HasKey("Id")
                        .HasName("pk_grupo_produtos");

                    b.ToTable("grupo_produtos");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("CodigoExterno")
                        .HasColumnType("text")
                        .HasColumnName("codigo_externo");

                    b.Property<string>("Descricao")
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<Guid>("GrupoProdutoId")
                        .HasColumnType("uuid")
                        .HasColumnName("grupo_produto_id");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<decimal>("Preco")
                        .HasColumnType("numeric")
                        .HasColumnName("preco");

                    b.Property<string>("UrlImagem")
                        .HasColumnType("text")
                        .HasColumnName("url_imagem");

                    b.HasKey("Id")
                        .HasName("pk_produtos");

                    b.HasIndex("GrupoProdutoId")
                        .HasDatabaseName("ix_produtos_grupo_produto_id");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<string>("Autenticacao")
                        .HasColumnType("text")
                        .HasColumnName("autenticacao");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("data_registro");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.HasKey("Id")
                        .HasName("pk_usuarios");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("UStart.Domain.Entities.Produto", b =>
                {
                    b.HasOne("UStart.Domain.Entities.GrupoProduto", "GrupoProduto")
                        .WithMany()
                        .HasForeignKey("GrupoProdutoId")
                        .HasConstraintName("fk_produtos_grupo_produtos_grupo_produto_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GrupoProduto");
                });
#pragma warning restore 612, 618
        }
    }
}
