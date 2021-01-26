using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeheretEvangelicalChurch.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MeheretEvangelicalChurch.Models
{
    public class MeheretEvangelicalChurchContext : IdentityDbContext<MeheretEvangelicalChurchUser>
    {

        public MeheretEvangelicalChurchContext(DbContextOptions<MeheretEvangelicalChurchContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Services> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Events>(entity =>
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

            builder.Entity<Services>(entity =>
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
        }
    }
}
