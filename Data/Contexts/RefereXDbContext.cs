using Microsoft.EntityFrameworkCore;
using RefereeX.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefereeX.Data.Contexts
{
    public class RefereXDbContext : DbContext
    {
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingAttendance> TrainingAttendances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=RefereeX;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Referee>()
                .HasOne(r => r.Rank)
                .WithMany(rk => rk.Referees)
                .HasForeignKey(r => r.Rank_Id);

            modelBuilder.Entity<Referee>()
                .HasOne(r => r.City)
                .WithMany(c => c.Referees)
                .HasForeignKey(r => r.City_Id);

            modelBuilder.Entity<TrainingAttendance>()
                .HasOne(ta => ta.Referee)
                .WithMany(r => r.TrainingAttendances)
                .HasForeignKey(ta => ta.Referee_Id);

            modelBuilder.Entity<TrainingAttendance>()
                .HasOne(ta => ta.Training)
                .WithMany(t => t.TrainingAttendances)
                .HasForeignKey(ta => ta.Training_Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
