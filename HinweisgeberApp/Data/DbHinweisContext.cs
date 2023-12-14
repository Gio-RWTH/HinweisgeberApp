using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HinweisgeberApp.Data
{
    public class DbHinweisContext : DbContext
	{

		public DbHinweisContext()
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		}
		public DbSet<Partner> Partners => Set<Partner>();
		public DbSet<Filiale> Filiales => Set<Filiale>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
				optionsBuilder.UseSqlServer("server=195.201.138.127; database = HWMainDB; user id = sa; password = 123Tobi123!; TrustServerCertificate=true;");
            }
        }

		public void ApplyMigrations()
		{
			Database.Migrate();
		}

        public bool TestConnection()
        {
            try
            {
                Database.OpenConnection();
                Database.CloseConnection();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
