using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Models
{
    public class CenterContext : DbContext
    {
        public CenterContext(DbContextOptions<CenterContext> options) : base(options)
        {

        }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Trener> Treners { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Center>().HasMany(p => p.Treners).WithRequired(c => c.Center);//one to many
            modelBuilder.Entity<Center>().HasMany(p => p.Aboniments).WithMany(c => c.Centers);//many to many
            modelBuilder.Entity<Center>().HasMany(p => p.Clients).WithRequired(c => c.Center);
            modelBuilder.Entity<Center>().HasMany(p => p.Rooms).WithRequired(c => c.Center);
            modelBuilder.Entity<Trener>().HasRequired(p => p.Category).WithRequiredPrincipal(c => c.Trener);
        }*/
    }
}
