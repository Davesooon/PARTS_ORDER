using Microsoft.EntityFrameworkCore;
using PARTS_ORDER.Database.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database
{
    public class PARTS_ORDER_DB : DbContext
    {
        private string _connString = "Server=(localdb)\\mssqllocaldb; Database=PARTS_ORDER; Trusted_Connection=True;";

        public DbSet<PARTS_SELLERS> partsSellers { get; set; }
        public DbSet<CHECK_PARTS> checkParts { get; set; }
        public DbSet<PARTS_HISTORY> partsHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PARTS_SELLERS>()
                .ToTable("PARTS_SELLER")
                .HasKey(k => k.ID);

            modelBuilder.Entity<CHECK_PARTS>()
                .ToTable("CHECK_PARTS")
                .HasKey(k => k.ID);

            modelBuilder.Entity<PARTS_HISTORY>()
                .ToTable("PARTS_HISTORY")
                .HasKey(k => k.ID);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connString);
        }
    }
}
