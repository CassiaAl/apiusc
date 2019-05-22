using MeuPrimeiroProjeto.Entities;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.BLL.Infra
{
	public interface ILoginBLL
	{
		Task<Login> GetLoginAsync(string name, string pwd);
		Task<Login> PostLoginAsync(Login login);
		Task<Login> PutLoginAsync(Login login);
	}
}
