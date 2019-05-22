using MeuPrimeiroProjeto.BLL.Infra;
using MeuPrimeiroProjetto.Api.UoW.Infra;

namespace MeuPrimeiroProjetto.Api.UoW
{
	public class LoginUoW : ILoginUoW
	{
		public ILoginBLL loginBLL { get; }

		public LoginUoW(ILoginBLL loginBLL)
		{
			this.loginBLL = loginBLL;
		}
	}
}
