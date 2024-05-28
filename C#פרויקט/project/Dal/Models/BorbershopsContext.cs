using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class BorbershopsContext : DbContext
{
    public BorbershopsContext(DbContextOptions<BorbershopsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Appointm__3214EC079E0C43C6");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.Branch).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppointmentsToBranches");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.IdBranch).HasName("PK__Branches__54205B04FFE6AC1B");

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clients__3214EC07B747AE46");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.Apoointment).WithMany(p => p.Clients)
                .HasForeignKey(d => d.ApoointmentId)
                .HasConstraintName("FK_AppointmentClients");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Workers__3214EC075711CDCC");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.JobType)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.Branch).WithMany(p => p.Workers)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_WorkersToBranches");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
