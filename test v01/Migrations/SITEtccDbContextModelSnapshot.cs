﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using test_v01.Repository;

#nullable disable

namespace test_v01.Migrations
{
    [DbContext(typeof(SITEtccDbContext))]
    partial class SITEtccDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DocumentoPalavraChave", b =>
                {
                    b.Property<int>("IdDocumento")
                        .HasColumnType("int")
                        .HasColumnName("id_documento");

                    b.Property<int>("IdPalavraChave")
                        .HasColumnType("int")
                        .HasColumnName("id_palavra_chave");

                    b.HasKey("IdDocumento", "IdPalavraChave")
                        .HasName("PK__document__7AB466A67BC07A39");

                    b.HasIndex("IdPalavraChave");

                    b.ToTable("documento_palavra_chave", (string)null);
                });

            modelBuilder.Entity("LocalizacaoPalavraChave", b =>
                {
                    b.Property<int>("IdLocalizacao")
                        .HasColumnType("int");

                    b.Property<int>("IdPalavraChave")
                        .HasColumnType("int");

                    b.HasKey("IdLocalizacao", "IdPalavraChave");

                    b.ToTable("LocalizacaoPalavraChave");
                });

            modelBuilder.Entity("PalavraChaveLocalizacao", b =>
                {
                    b.Property<int>("IdPalavraChave")
                        .HasColumnType("int")
                        .HasColumnName("id_palavra_chave");

                    b.Property<int>("IdLocalizacao")
                        .HasColumnType("int")
                        .HasColumnName("id_localizacao");

                    b.HasKey("IdPalavraChave", "IdLocalizacao")
                        .HasName("PK__palavra___EA4618A5BD4D02FD");

                    b.HasIndex("IdLocalizacao");

                    b.ToTable("palavra_chave_localizacao", (string)null);
                });

            modelBuilder.Entity("test_v01.Repository.Models.Documento", b =>
                {
                    b.Property<int>("Documentoid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("documentoid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Documentoid"));

                    b.Property<string>("Caminhodocumento")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("caminhodocumento");

                    b.Property<string>("Documentonome")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("documentonome");

                    b.Property<byte[]>("FileData")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("Idusuario")
                        .HasColumnType("int")
                        .HasColumnName("idusuario");

                    b.HasKey("Documentoid")
                        .HasName("PK__document__69A574B52B997C43");

                    b.HasIndex("Idusuario");

                    b.ToTable("documento");
                });

            modelBuilder.Entity("test_v01.Repository.Models.Localizacao", b =>
                {
                    b.Property<int>("IdLocalizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_localizacao");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLocalizacao"));

                    b.Property<int?>("Pagina")
                        .HasColumnType("int")
                        .HasColumnName("pagina");

                    b.Property<int?>("Paragrafo")
                        .HasColumnType("int")
                        .HasColumnName("paragrafo");

                    b.HasKey("IdLocalizacao")
                        .HasName("PK__localiza__3EE0C968DBF23C8D");

                    b.ToTable("localizacao");
                });

            modelBuilder.Entity("test_v01.Repository.Models.PalavraChave", b =>
                {
                    b.Property<int>("IdPalavraChave")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_palavra_chave");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPalavraChave"));

                    b.Property<string>("Palavra")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("palavra");

                    b.HasKey("IdPalavraChave")
                        .HasName("PK__palavra___79A814338B0DFD39");

                    b.ToTable("palavra_chave");
                });

            modelBuilder.Entity("test_v01.Repository.Models.Usuario", b =>
                {
                    b.Property<int>("Idusuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idusuario");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Idusuario"));

                    b.Property<string>("Emailusuario")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("emailusuario");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Nomeusuario")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nomeusuario");

                    b.Property<string>("Recmail")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("recmail");

                    b.Property<string>("Senhausuario")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("senhausuario");

                    b.Property<string>("Telefoneusuario")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("telefoneusuario");

                    b.HasKey("Idusuario")
                        .HasName("PK__usuario__080A9743E8FE2A70");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("DocumentoPalavraChave", b =>
                {
                    b.HasOne("test_v01.Repository.Models.Documento", null)
                        .WithMany()
                        .HasForeignKey("IdDocumento")
                        .IsRequired()
                        .HasConstraintName("fk_documento");

                    b.HasOne("test_v01.Repository.Models.PalavraChave", null)
                        .WithMany()
                        .HasForeignKey("IdPalavraChave")
                        .IsRequired()
                        .HasConstraintName("fk_palavra_chave");
                });

            modelBuilder.Entity("PalavraChaveLocalizacao", b =>
                {
                    b.HasOne("test_v01.Repository.Models.Localizacao", null)
                        .WithMany()
                        .HasForeignKey("IdLocalizacao")
                        .IsRequired()
                        .HasConstraintName("fk_localizacao");

                    b.HasOne("test_v01.Repository.Models.PalavraChave", null)
                        .WithMany()
                        .HasForeignKey("IdPalavraChave")
                        .IsRequired()
                        .HasConstraintName("fk_palavra_chave_localizacao");
                });

            modelBuilder.Entity("test_v01.Repository.Models.Documento", b =>
                {
                    b.HasOne("test_v01.Repository.Models.Usuario", "IdusuarioNavigation")
                        .WithMany("Documentos")
                        .HasForeignKey("Idusuario")
                        .HasConstraintName("fk_usuario_documento");

                    b.Navigation("IdusuarioNavigation");
                });

            modelBuilder.Entity("test_v01.Repository.Models.Usuario", b =>
                {
                    b.Navigation("Documentos");
                });
#pragma warning restore 612, 618
        }
    }
}
