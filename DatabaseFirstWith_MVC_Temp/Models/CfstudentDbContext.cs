using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstWith_MVC_Temp.Models;

public partial class CfstudentDbContext : DbContext
{
    public CfstudentDbContext()
    {
    }

    public CfstudentDbContext(DbContextOptions<CfstudentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-2713M6I\\MSSQLSERVER04;Initial Catalog=CFstudentDB;Integrated Security=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Employee");

            entity.Property(e => e.Ecity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ECity");
            entity.Property(e => e.Egender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EGender");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EName");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Sgender)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SGender");
            entity.Property(e => e.Sname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
