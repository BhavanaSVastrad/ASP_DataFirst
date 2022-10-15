using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASP_First.Models
{
    public partial class TE_API_AngularContext : DbContext
    {
        public TE_API_AngularContext()
        {
        }

        public TE_API_AngularContext(DbContextOptions<TE_API_AngularContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Registration> Registrations { get; set; } = null!;
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ELW5139\\SQLEXPRESS01;Database=TE_API_Angular;Trusted_Connection=True;");
           */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>(entity =>
            {
                entity.ToTable("Registration");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.Password)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Useremail)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("useremail");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
