using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAO.Contexts {
    public partial class JeymerContext : DbContext
    {
        public JeymerContext()
        {
        }

        public JeymerContext(DbContextOptions<JeymerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RequestModel> RequestModel { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-C14ILB8\\SQLEXPRESS01;Initial Catalog=Jeymer;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequestModel>(entity =>
            {
                entity.HasKey(e => e.RequestId);

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.UserName).HasMaxLength(10);

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.RequestModel)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("FK_RequestModel_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.RequestId).ValueGeneratedOnAdd();
            });
        }
    }
}
