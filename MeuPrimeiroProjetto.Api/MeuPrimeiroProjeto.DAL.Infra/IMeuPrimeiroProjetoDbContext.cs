using MeuPrimeiroProjeto.Entities;
using System.Linq;

namespace MeuPrimeiroProjeto.DAL.Infra
{
	public interface IMeuPrimeiroProjetoDbContext: IDataBaseContext
	{
		IQueryable<Login> QueryLogin { get; }
	}
}
