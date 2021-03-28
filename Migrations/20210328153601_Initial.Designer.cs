﻿// <auto-generated />
using System;
using HIPS_TS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HIPS_TS.Migrations
{
    [DbContext(typeof(TechniqueContext))]
    [Migration("20210328153601_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("technique")
                .HasAnnotation("Relational:Collation", "Finnish_Swedish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HIPS_TS.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Category", "technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.CategoryName", b =>
                {
                    b.Property<int>("NameId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("NameId", "CategoryId")
                        .HasName("PK_techniquetypename");

                    b.HasIndex(new[] { "CategoryId" }, "fkIdx_100");

                    b.ToTable("CategoryName", "technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.Description", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Description", "technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.Jin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Jin", "technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.JinName", b =>
                {
                    b.Property<int>("JinId")
                        .HasColumnType("int");

                    b.Property<int>("NameId")
                        .HasColumnType("int");

                    b.HasKey("JinId", "NameId")
                        .HasName("PK_jinname");

                    b.HasIndex(new[] { "JinId" }, "fkIdx_317");

                    b.ToTable("JinName", "technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.Technique", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("JinId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "JinId" }, "fkIdx_310");

                    b.ToTable("Technique", "technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.TechniqueCategory", b =>
                {
                    b.Property<int>("TechniqueId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("TechniqueId", "CategoryId")
                        .HasName("PK_techniquecategory");

                    b.HasIndex(new[] { "CategoryId" }, "fkIdx_139");

                    b.HasIndex(new[] { "TechniqueId" }, "fkIdx_142");

                    b.ToTable("TechniqueCategory", "technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.TechniqueDescription", b =>
                {
                    b.Property<int>("TechniqueId")
                        .HasColumnType("int");

                    b.Property<int>("DescriptionId")
                        .HasColumnType("int");

                    b.HasKey("TechniqueId", "DescriptionId")
                        .HasName("PK_techniquedescription");

                    b.HasIndex(new[] { "DescriptionId" }, "fkIdx_90");

                    b.HasIndex(new[] { "TechniqueId" }, "fkIdx_93");

                    b.ToTable("TechniqueDescription", "technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.TechniqueName", b =>
                {
                    b.Property<int>("NameId")
                        .HasColumnType("int");

                    b.Property<int>("TechniqueId")
                        .HasColumnType("int");

                    b.HasKey("NameId", "TechniqueId")
                        .HasName("PK_techniquename");

                    b.HasIndex(new[] { "TechniqueId" }, "fkIdx_107");

                    b.ToTable("TechniqueName", "technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.TechniqueType", b =>
                {
                    b.Property<int>("TechniqueId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("TechniqueId", "TypeId")
                        .HasName("PK_techniquetype");

                    b.HasIndex(new[] { "TypeId" }, "fkIdx_129");

                    b.HasIndex(new[] { "TechniqueId" }, "fkIdx_132");

                    b.ToTable("TechniqueType", "technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.TypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UdatedBy")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Type", "technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.TypeName", b =>
                {
                    b.Property<int>("NameId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("NameId", "TypeId")
                        .HasName("PK_typename");

                    b.HasIndex(new[] { "TypeId" }, "fkIdx_122");

                    b.ToTable("TypeName", "technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.CategoryName", b =>
                {
                    b.HasOne("HIPS_TS.Models.Category", "Category")
                        .WithMany("CategoryNames")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_CategoryName_Category")
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HIPS_TS.Models.JinName", b =>
                {
                    b.HasOne("HIPS_TS.Models.Jin", "Jin")
                        .WithMany("JinNames")
                        .HasForeignKey("JinId")
                        .HasConstraintName("FK_JinName_Jin")
                        .IsRequired();

                    b.Navigation("Jin");
                });

            modelBuilder.Entity("HIPS_TS.Models.Technique", b =>
                {
                    b.HasOne("HIPS_TS.Models.Jin", "Jin")
                        .WithMany("Techniques")
                        .HasForeignKey("JinId")
                        .HasConstraintName("FK_Technique_Jin");

                    b.Navigation("Jin");
                });

            modelBuilder.Entity("HIPS_TS.Models.TechniqueCategory", b =>
                {
                    b.HasOne("HIPS_TS.Models.Category", "Category")
                        .WithMany("TechniqueCategories")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_TechniqueCategory_Category")
                        .IsRequired();

                    b.HasOne("HIPS_TS.Models.Technique", "Technique")
                        .WithMany("TechniqueCategories")
                        .HasForeignKey("TechniqueId")
                        .HasConstraintName("FK_TechniqueCategory_Technique")
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.TechniqueDescription", b =>
                {
                    b.HasOne("HIPS_TS.Models.Description", "Description")
                        .WithMany("TechniqueDescriptions")
                        .HasForeignKey("DescriptionId")
                        .HasConstraintName("FK_TechniqueDescription_Description")
                        .IsRequired();

                    b.HasOne("HIPS_TS.Models.Technique", "Technique")
                        .WithMany("TechniqueDescriptions")
                        .HasForeignKey("TechniqueId")
                        .HasConstraintName("FK_TechniqueDescription_Technique")
                        .IsRequired();

                    b.Navigation("Description");

                    b.Navigation("Technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.TechniqueName", b =>
                {
                    b.HasOne("HIPS_TS.Models.Technique", "Technique")
                        .WithMany("TechniqueNames")
                        .HasForeignKey("TechniqueId")
                        .HasConstraintName("FK_TechniqueName_Technique")
                        .IsRequired();

                    b.Navigation("Technique");
                });

            modelBuilder.Entity("HIPS_TS.Models.TechniqueType", b =>
                {
                    b.HasOne("HIPS_TS.Models.Technique", "Technique")
                        .WithMany("TechniqueTypes")
                        .HasForeignKey("TechniqueId")
                        .HasConstraintName("FK_TechniqueType_Technique")
                        .IsRequired();

                    b.HasOne("HIPS_TS.Models.TypeEntity", "Type")
                        .WithMany("TechniqueTypes")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK_TechniqueType_Type")
                        .IsRequired();

                    b.Navigation("Technique");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("HIPS_TS.Models.TypeName", b =>
                {
                    b.HasOne("HIPS_TS.Models.TypeEntity", "Type")
                        .WithMany("TypeNames")
                        .HasForeignKey("TypeId")
                        .HasConstraintName("FK_TypeName_Type")
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("HIPS_TS.Models.Category", b =>
                {
                    b.Navigation("CategoryNames");

                    b.Navigation("TechniqueCategories");
                });

            modelBuilder.Entity("HIPS_TS.Models.Description", b =>
                {
                    b.Navigation("TechniqueDescriptions");
                });

            modelBuilder.Entity("HIPS_TS.Models.Jin", b =>
                {
                    b.Navigation("JinNames");

                    b.Navigation("Techniques");
                });

            modelBuilder.Entity("HIPS_TS.Models.Technique", b =>
                {
                    b.Navigation("TechniqueCategories");

                    b.Navigation("TechniqueDescriptions");

                    b.Navigation("TechniqueNames");

                    b.Navigation("TechniqueTypes");
                });

            modelBuilder.Entity("HIPS_TS.Models.TypeEntity", b =>
                {
                    b.Navigation("TechniqueTypes");

                    b.Navigation("TypeNames");
                });
#pragma warning restore 612, 618
        }
    }
}
