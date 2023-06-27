using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PARTS_ORDER.Database.APP_AUTH_Tables;
using PARTS_ORDER.Database.PARTS_ORDER_Tables;
using PARTS_ORDER.Database.PARTS_ORDER_Views;
using PARTS_ORDER.Database.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database
{
    public class DatabaseInitializer : DbContext, IDatabaseInitializer
    {
        private string _connString = "Server=(localdb)\\mssqllocaldb; Database=PARTS_ORDER; Trusted_Connection=True;";

        public DatabaseInitializer() : base()
        {
        }

        public DbSet<PARTS_SELLER> partsSellers { get; set; }
        public DbSet<CHECK_PARTS> checkParts { get; set; }
        public DbSet<LOGIN_USERS> loginUsers { get; set; }
        public DbSet<OPERATOR> Operator { get; set; }
        public DbSet<PARTS_INFO_V> partsInfoV { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PARTS_SELLER>()
                .ToTable("PARTS_SELLER")
                .HasKey(k => k.ID);

            modelBuilder.Entity<CHECK_PARTS>()
                .ToTable("CHECK_PARTS")
                .HasKey(k => k.ID_CZĘŚCI);

            modelBuilder.Entity<LOGIN_USERS>()
                .ToTable("LOGIN_USERS")
                .HasKey(x => x.ID);

            modelBuilder.Entity<OPERATOR>()
                .ToTable("OPERATOR")
                .HasKey(k => k.PESEL);

            modelBuilder.Entity<PARTS_INFO_V>()
                .ToView("PARTS_INFO_V")
                .HasNoKey();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connString);
        }

        public async Task SeedData()
        {
            using (var partsOrderContext = new DatabaseInitializer())
            {
                if (!partsOrderContext.Operator.Any())
                {
                    partsOrderContext.Database
                        .ExecuteSql($"SET IDENTITY_INSERT dbo.OPERATOR ON; INSERT INTO dbo.OPERATOR(PESEL, IMIĘ, NAZWISKO, STANOWISKO) VALUES(00253000123, 'JAN', 'KOWALSKI', 'MISTRZ ZMIANY'); INSERT INTO dbo.OPERATOR(PESEL, IMIĘ, NAZWISKO, STANOWISKO) VALUES(01280900421, 'ADAM', 'NOWAK', 'MŁODSZY SPECJALISTA DS. IT'); SET IDENTITY_INSERT dbo.OPERATOR OFF;");
                }

                if (!partsOrderContext.loginUsers.Any())
                {
                    partsOrderContext.Database
                        .ExecuteSql($"SET IDENTITY_INSERT dbo.LOGIN_USERS ON; INSERT INTO dbo.LOGIN_USERS(ID, LOGIN, HASŁO, ADMIN) VALUES(1, 'JKOWALSKI', '123456', 'NO'); INSERT INTO dbo.LOGIN_USERS(ID, LOGIN, HASŁO, ADMIN) VALUES(2, 'ANOWAK', '654321', 'YES'); SET IDENTITY_INSERT dbo.LOGIN_USERS OFF;");
                }

                if (!partsOrderContext.checkParts.Any())
                {
                    partsOrderContext.Database
                        .ExecuteSql($"SET IDENTITY_INSERT dbo.CHECK_PARTS ON; INSERT INTO dbo.CHECK_PARTS(ID_CZĘŚCI, NAZWA, KLUCZ_PRODUKTU, WYDAWCA, ILOŚĆ) VALUES(1, 'STALOWA NAKŁADKA', 9028241, 'SIEMENS', 5); INSERT INTO dbo.CHECK_PARTS(ID_CZĘŚCI, NAZWA, KLUCZ_PRODUKTU, WYDAWCA, ILOŚĆ) VALUES(2, 'WBUDOWANY SENSOR', 7492012, 'HONEYWELL', 3); SET IDENTITY_INSERT dbo.CHECK_PARTS OFF;");
                }

                if (!partsOrderContext.partsSellers.Any())
                {
                    partsOrderContext.Database
                        .ExecuteSql($"SET IDENTITY_INSERT dbo.PARTS_SELLER ON; INSERT INTO dbo.PARTS_SELLER(ID, WYDAWCA, ID_CZĘŚCI, KOSZT, DOSTĘPNOŚĆ) VALUES(1, 'HONEYWELL', 2, 4959.50, 'Y'); INSERT INTO dbo.PARTS_SELLER(ID, WYDAWCA, ID_CZĘŚCI, KOSZT, DOSTĘPNOŚĆ) VALUES(2, 'SIEMENS', 1, 829.00, 'Y'); SET IDENTITY_INSERT dbo.PARTS_SELLER OFF;");
                }

                await partsOrderContext.SaveChangesAsync();
            }
        }
    }
}
