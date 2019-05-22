using MeuPrimeiroProjeto.BLL.Infra;

namespace MeuPrimeiroProjetto.Api.UoW.Infra
{
	public interface ILoginUoW
	{
		ILoginBLL loginBLL { get; }
	}
}
