using MeuPrimeiroProjeto.Helpers;
using MeuPrimeiroProjetto.Api.UoW;
using MeuPrimeiroProjetto.Api.UoW.Infra;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MeuPrimeiroProjetto.Api.Controllers
{

	[ApiController]
	public class LoginController : ControllerBase
	{
		private ILoginUoW _loginUoW;
		public LoginController(ILoginUoW loginUoW)
		{
			_loginUoW = loginUoW;
		}
	}

	/// <summary>
	/// SALVAR DADOS DE ACESSO DO USUARIO
	/// </summary>
	/// <param name="login">OBJETO LINK</param>
	/// <returns>OBJETO RESPONSE</returns>
	/// 
	[Route("api/login/post"), HttpGet]
	public async Task<IActionResult> PostLogin(Login login)
	{
		var response = new ResponseContent();
		try
		{
			response.Object = await LoginUoW.loginBLL.PostLoginAsync(login);
			response.Message = "Requisição realizada com sucesso.";
			response.status = true;
		}
		catch (Exception ex)
		{
			response.Message = ex.Message;
			response.status = false;
		}
		return Ok(response);
	}

	}

}