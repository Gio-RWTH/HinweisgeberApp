using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinweisgeberApp.Data
{
    public class DbHinweisContext : DbContext
    {
		public DbSet<Partner> Partners => Set<Partner>();
		public DbSet<Filiale> Filiales => Set<Filiale>();

	}
}
