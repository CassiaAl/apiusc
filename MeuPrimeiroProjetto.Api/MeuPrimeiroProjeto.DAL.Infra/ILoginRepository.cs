using MeuPrimeiroProjeto.Entities;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.DAL.Infra
{
	public interface ILoginRepository
	{

		Task<Login> GetLoginAsync(string name, string pwd);
		Task<Login> PostLoginAsync(Login login);
		Task<Login> PutLoginAsync(Login login);
	}
}
