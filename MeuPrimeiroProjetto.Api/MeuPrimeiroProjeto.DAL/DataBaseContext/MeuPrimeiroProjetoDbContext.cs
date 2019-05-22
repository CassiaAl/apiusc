using MeuPrimeiroProjeto.DAL.Infra;
using MeuPrimeiroProjeto.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace MeuPrimeiroProjeto.DAL.DataBaseContext
{
	public class MeuPrimeiroProjetoDbContext: DbContext, IMeuPrimeiroProjetoDbContext
	{
		private IConfiguration configuration;
		public MeuPrimeiroProjetoDbContext(IConfiguration config)
		{
			configuration = config;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var connection = configuration.GetConnectionString("MeuPrimeiroProjetoDbBase");
			optionsBuilder.UseSqlServer(connection);
			base.OnConfiguring(optionsBuilder);
		}

		public void SetModified(object entity)
		{
			Entry(entity).State = EntityState.Modified;
		}

		public DbSet<Login> Login { get; set; }
		public IQueryable<Login> QueryLogin { get { return Login; } }
	}
}
