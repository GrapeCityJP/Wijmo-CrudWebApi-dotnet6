using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace webinar0302.Models
{
    public partial class test2022Context : DbContext
    {
        public test2022Context()
        {
        }

        public test2022Context(DbContextOptions<test2022Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseMySql("server=localhost;database=test2022;user=root;password=*********", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.24-mysql"));
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Customer)
                    .HasMaxLength(256)
                    .HasColumnName("customer");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Product)
                    .HasMaxLength(256)
                    .HasColumnName("product");

                entity.Property(e => e.Staff)
                    .HasMaxLength(256)
                    .HasColumnName("staff");

                entity.Property(e => e.Unitprice).HasColumnName("unitprice");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
