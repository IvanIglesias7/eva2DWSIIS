using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


//Esta clase servirá como Contexto de todas las tablas de la base de datos y es la que se va a encargar de 
//hacer las transferencias con la base de datos

namespace DAL.Model;
public partial class BdEvaluacionContext : DbContext
{
    public BdEvaluacionContext()
    {
    }

    public BdEvaluacionContext(DbContextOptions<BdEvaluacionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EvaCatEvaluacion> EvaCatEvaluacions { get; set; }

    public virtual DbSet<EvaTchNotasEvaluacion> EvaTchNotasEvaluacions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EvaCatEvaluacion>(entity =>
        {
            entity.HasKey(e => e.CodEvaluacion).HasName("eva_cat_evaluacion_pkey");

            entity.ToTable("eva_cat_evaluacion", "sc_evaluacion");

            entity.Property(e => e.CodEvaluacion)
                .HasColumnType("character varying")
                .HasColumnName("cod_evaluacion");
            entity.Property(e => e.DescEvaluacion)
                .HasColumnType("character varying")
                .HasColumnName("desc_evaluacion");
        });

        modelBuilder.Entity<EvaTchNotasEvaluacion>(entity =>
        {
            entity.HasKey(e => e.IdNotaEvaluacion).HasName("eva_tch_notas_evaluacion_pkey");

            entity.ToTable("eva_tch_notas_evaluacion", "sc_evaluacion");

            entity.Property(e => e.IdNotaEvaluacion).HasColumnName("id_nota_evaluacion");
            entity.Property(e => e.CodAlumno)
                .HasColumnType("character varying")
                .HasColumnName("cod_alumno");
            entity.Property(e => e.CodEvaluacion)
                .HasColumnType("character varying")
                .HasColumnName("cod_evaluacion");
            entity.Property(e => e.MdFch)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("md_fch");
            entity.Property(e => e.MdUuid)
                .HasColumnType("character varying")
                .HasColumnName("md_uuid");
            entity.Property(e => e.NotaEvaluacion).HasColumnName("nota_evaluacion");

            entity.HasOne(d => d.CodEvaluacionNavigation).WithMany(p => p.EvaTchNotasEvaluacions)
                .HasForeignKey(d => d.CodEvaluacion)
                .HasConstraintName("cod_evaluacion_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
