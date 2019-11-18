﻿// <auto-generated />
using System;
using DragonWinterIsComing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DragonWinterIsComing.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DragonWinterIsComing.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("DragonWinterIsComing.Models.Dragao", b =>
                {
                    b.Property<int>("DragaoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cor");

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Dieta");

                    b.Property<string>("Habitat");

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.Property<string>("Origem");

                    b.Property<string>("Raca");

                    b.HasKey("DragaoId");

                    b.ToTable("Dragoes");
                });

            modelBuilder.Entity("DragonWinterIsComing.Models.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Casa")
                        .IsRequired();

                    b.Property<string>("Cidade")
                        .IsRequired();

                    b.Property<string>("ComparacaoSenha")
                        .IsRequired();

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<DateTime>("CriadoEm");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Reino")
                        .IsRequired();

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.Property<int>("Tipo");

                    b.HasKey("PessoaId");

                    b.ToTable("Pessoas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pessoa");
                });

            modelBuilder.Entity("DragonWinterIsComing.Models.Viagem", b =>
                {
                    b.Property<int>("IdViagem")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<int?>("DragaoId");

                    b.Property<string>("LocDestino");

                    b.Property<string>("LocOrigem");

                    b.Property<double>("Nota");

                    b.Property<int?>("PilotoPessoaId");

                    b.Property<bool>("PossuiBagagem");

                    b.Property<string>("Status");

                    b.Property<int?>("UsuarioPessoaId");

                    b.HasKey("IdViagem");

                    b.HasIndex("DragaoId");

                    b.HasIndex("PilotoPessoaId");

                    b.HasIndex("UsuarioPessoaId");

                    b.ToTable("Viagem");
                });

            modelBuilder.Entity("DragonWinterIsComing.Models.Piloto", b =>
                {
                    b.HasBaseType("DragonWinterIsComing.Models.Pessoa");

                    b.Property<string>("Cdh");

                    b.Property<int?>("DragaoId");

                    b.Property<double>("PilotoMedia");

                    b.Property<string>("Status");

                    b.HasIndex("DragaoId");

                    b.ToTable("Pilotos");

                    b.HasDiscriminator().HasValue("Piloto");
                });

            modelBuilder.Entity("DragonWinterIsComing.Models.Usuario", b =>
                {
                    b.HasBaseType("DragonWinterIsComing.Models.Pessoa");


                    b.ToTable("Usuario");

                    b.HasDiscriminator().HasValue("Usuario");
                });

            modelBuilder.Entity("DragonWinterIsComing.Models.Viagem", b =>
                {
                    b.HasOne("DragonWinterIsComing.Models.Dragao", "Dragao")
                        .WithMany()
                        .HasForeignKey("DragaoId");

                    b.HasOne("DragonWinterIsComing.Models.Piloto", "Piloto")
                        .WithMany()
                        .HasForeignKey("PilotoPessoaId");

                    b.HasOne("DragonWinterIsComing.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioPessoaId");
                });

            modelBuilder.Entity("DragonWinterIsComing.Models.Piloto", b =>
                {
                    b.HasOne("DragonWinterIsComing.Models.Dragao", "Dragao")
                        .WithMany()
                        .HasForeignKey("DragaoId");
                });
#pragma warning restore 612, 618
        }
    }
}
