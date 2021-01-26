using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MeheretEvangelicalChurch.Models
{
    public partial class MeheretEvangelicalChurchDBContext : DbContext
    {
        public MeheretEvangelicalChurchDBContext()
        {
        }

        public MeheretEvangelicalChurchDBContext(DbContextOptions<MeheretEvangelicalChurchDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Services> Services { get; set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localDB)\\MsSqlLocalDB;Database=MeheretEvangelicalChurch;Trusted_Connection=True;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.Property(e => e.EventId)
                    .HasColumnName("eventID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EventDate)
                    .HasColumnName("eventDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventDescription)
                    .HasColumnName("eventDescription")
                    .HasColumnType("text");

                entity.Property(e => e.EventImage)
                    .HasColumnName("eventImage")
                    .HasColumnType("text");

                entity.Property(e => e.EventTitle)
                    .HasColumnName("eventTitle")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.Property(e => e.ServiceId)
                   .HasColumnName("serviceID")
                   .ValueGeneratedNever();

                entity.Property(e => e.ServiceDate)
                    .HasColumnName("serviceDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ServiceDescription)
                    .HasColumnName("serviceDescription")
                    .HasColumnType("text");

                entity.Property(e => e.ServiceImage)
                    .HasColumnName("serviceImage")
                    .HasColumnType("text");

                entity.Property(e => e.ServiceTitle)
                    .HasColumnName("serviceTitle")
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
