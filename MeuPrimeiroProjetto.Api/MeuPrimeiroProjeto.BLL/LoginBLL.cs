using MeuPrimeiroProjeto.BLL.Infra;
using MeuPrimeiroProjeto.DAL.Infra;
using MeuPrimeiroProjeto.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.BLL
{
	public class LoginBLL : ILoginBLL
	{
		private readonly ILoginRepository _loginRepository;

		public LoginBLL(ILoginRepository loginRepository)
		{
			_loginRepository = loginRepository;
		}


		/// <summary>
		/// METODO RESPONSAVEL PELA VALIDACAO DOS DADOS UTILIZADOS PARA A CONSULTA DE LOGIN
		/// </summary>
		/// <param name="name">NOME</param>
		/// <param name="pwd">SENHA</param>
		/// <returns>OBJETO LOGIN</returns>
		/// 
		public async Task<Login> GetLoginAsync(string name, string pwd)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(name))
				{
					throw new Exception("Preencha o login do usuário.");
				}

				if (string.IsNullOrWhiteSpace(pwd))
				{
					throw new Exception("Preencha a senha do usuário.");
				}

				return await _loginRepository.GetLoginAsync(name, pwd);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


		/// <summary>
		/// METODO RESPONSAVEL PELA VALIDACAO DOS DADOS UTILIZADOS PARA A INCLUSAO DE LOGIN
		/// </summary>
		/// <param name="login">OBJETO LOGIN</param>
		/// <returns>OBJETO LOGIN</returns>

		public async Task<Login> PostLoginAsync(Login login)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(login.LGN_LOGIN))
				{
					throw new Exception("Preencha o nome do usuário.");
				}

				if (string.IsNullOrWhiteSpace(login.LGN_SENHA))
				{
					throw new Exception("Preencha a senha do usuário.");
				}

				return await _loginRepository.PostLoginAsync(login);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


		/// <summary>
		/// METODO RESPONSAVEL PELA VALIDACAO DOS DADOS UTILIZADOS PARA A ALTERAÇÃO DO LOGIN
		/// </summary>
		/// <param name="login">OBJETO LOGIN</param>
		/// <returns>OBJETO LOGIN</returns>

		public async Task<Login> PutLoginAsync(Login login)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(login.LGN_LOGIN))
				{
					throw new Exception("Preencha o nome do usuário.");
				}

				if (string.IsNullOrWhiteSpace(login.LGN_SENHA))
				{
					throw new Exception("Preencha a senha do usuário.");
				}

				return await _loginRepository.PutLoginAsync(login);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
