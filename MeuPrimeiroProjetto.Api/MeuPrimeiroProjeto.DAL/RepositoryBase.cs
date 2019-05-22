using MeuPrimeiroProjeto.DAL.Infra;


namespace MeuPrimeiroProjeto.DAL

{
	public abstract class RepositoryBase<TContext> where TContext : IMeuPrimeiroProjetoDbContext
	{
		protected TContext _dbContext;

		public RepositoryBase(TContext dbContext)
		{
			_dbContext = dbContext;
		}
	}

}
