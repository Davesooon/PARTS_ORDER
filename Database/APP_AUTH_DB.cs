using Microsoft.EntityFrameworkCore;
using PARTS_ORDER.Database.APP_AUTH_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database
{
    public class APP_AUTH_DB : DbContext
    {
        private string _connString = "Server=(localdb)\\mssqllocaldb; Database=APP_AUTH; Trusted_Connection=True;";

        public DbSet<LOGIN_USERS> loginUsers { get; set; }
        public DbSet<PASS_SALT> salt { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LOGIN_USERS>()
                .ToTable("LOGIN_USERS")
                .HasKey(x => x.ID);

            modelBuilder.Entity<PASS_SALT>()
                .ToTable("SALT")
                .HasKey(x => x.ID);
        }
    }
}
