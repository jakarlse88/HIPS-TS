using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HIPS_TS.Models;

#nullable disable

namespace HIPS_TS.Data
{
    public partial class TechniqueContext : DbContext
    {
        public TechniqueContext()
        {
        }

        public TechniqueContext(DbContextOptions<TechniqueContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryName> CategoryNames { get; set; }
        public virtual DbSet<Description> Descriptions { get; set; }
        public virtual DbSet<Jin> Jins { get; set; }
        public virtual DbSet<JinName> JinNames { get; set; }
        public virtual DbSet<Technique> Techniques { get; set; }
        public virtual DbSet<TechniqueCategory> TechniqueCategories { get; set; }
        public virtual DbSet<TechniqueDescription> TechniqueDescriptions { get; set; }
        public virtual DbSet<TechniqueName> TechniqueNames { get; set; }
        public virtual DbSet<TechniqueType> TechniqueTypes { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<TypeName> TypeNames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Finnish_Swedish_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category", "technique");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoryName>(entity =>
            {
                entity.HasKey(e => new { e.NameId, e.CategoryId })
                    .HasName("PK_techniquetypename");

                entity.ToTable("CategoryName", "technique");

                entity.HasIndex(e => e.CategoryId, "fkIdx_100");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryNames)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryName_Category");
            });

            modelBuilder.Entity<Description>(entity =>
            {
                entity.ToTable("Description", "technique");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Jin>(entity =>
            {
                entity.ToTable("Jin", "technique");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JinName>(entity =>
            {
                entity.HasKey(e => new { e.JinId, e.NameId })
                    .HasName("PK_jinname");

                entity.ToTable("JinName", "technique");

                entity.HasIndex(e => e.JinId, "fkIdx_317");

                entity.HasOne(d => d.Jin)
                    .WithMany(p => p.JinNames)
                    .HasForeignKey(d => d.JinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JinName_Jin");
            });

            modelBuilder.Entity<Technique>(entity =>
            {
                entity.ToTable("Technique", "technique");

                entity.HasIndex(e => e.JinId, "fkIdx_310");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Jin)
                    .WithMany(p => p.Techniques)
                    .HasForeignKey(d => d.JinId)
                    .HasConstraintName("FK_Technique_Jin");
            });

            modelBuilder.Entity<TechniqueCategory>(entity =>
            {
                entity.HasKey(e => new { e.TechniqueId, e.CategoryId })
                    .HasName("PK_techniquecategory");

                entity.ToTable("TechniqueCategory", "technique");

                entity.HasIndex(e => e.CategoryId, "fkIdx_139");

                entity.HasIndex(e => e.TechniqueId, "fkIdx_142");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TechniqueCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TechniqueCategory_Category");

                entity.HasOne(d => d.Technique)
                    .WithMany(p => p.TechniqueCategories)
                    .HasForeignKey(d => d.TechniqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TechniqueCategory_Technique");
            });

            modelBuilder.Entity<TechniqueDescription>(entity =>
            {
                entity.HasKey(e => new { e.TechniqueId, e.DescriptionId })
                    .HasName("PK_techniquedescription");

                entity.ToTable("TechniqueDescription", "technique");

                entity.HasIndex(e => e.DescriptionId, "fkIdx_90");

                entity.HasIndex(e => e.TechniqueId, "fkIdx_93");

                entity.HasOne(d => d.Description)
                    .WithMany(p => p.TechniqueDescriptions)
                    .HasForeignKey(d => d.DescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TechniqueDescription_Description");

                entity.HasOne(d => d.Technique)
                    .WithMany(p => p.TechniqueDescriptions)
                    .HasForeignKey(d => d.TechniqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TechniqueDescription_Technique");
            });

            modelBuilder.Entity<TechniqueName>(entity =>
            {
                entity.HasKey(e => new { e.NameId, e.TechniqueId })
                    .HasName("PK_techniquename");

                entity.ToTable("TechniqueName", "technique");

                entity.HasIndex(e => e.TechniqueId, "fkIdx_107");

                entity.HasOne(d => d.Technique)
                    .WithMany(p => p.TechniqueNames)
                    .HasForeignKey(d => d.TechniqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TechniqueName_Technique");
            });

            modelBuilder.Entity<TechniqueType>(entity =>
            {
                entity.HasKey(e => new { e.TechniqueId, e.TypeId })
                    .HasName("PK_techniquetype");

                entity.ToTable("TechniqueType", "technique");

                entity.HasIndex(e => e.TypeId, "fkIdx_129");

                entity.HasIndex(e => e.TechniqueId, "fkIdx_132");

                entity.HasOne(d => d.Technique)
                    .WithMany(p => p.TechniqueTypes)
                    .HasForeignKey(d => d.TechniqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TechniqueType_Technique");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TechniqueTypes)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TechniqueType_Type");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("Type", "technique");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<TypeName>(entity =>
            {
                entity.HasKey(e => new { e.NameId, e.TypeId })
                    .HasName("PK_typename");

                entity.ToTable("TypeName", "technique");

                entity.HasIndex(e => e.TypeId, "fkIdx_122");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TypeNames)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeName_Type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
