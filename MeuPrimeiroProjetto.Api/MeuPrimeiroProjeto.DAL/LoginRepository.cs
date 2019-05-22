using MeuPrimeiroProjeto.DAL.Infra;
using MeuPrimeiroProjeto.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace MeuPrimeiroProjeto.DAL
{
	public class LoginRepository : RepositoryBase<IMeuPrimeiroProjetoDbContext>, ILoginRepository
	{
		public LoginRepository(IMeuPrimeiroProjetoDbContext dbContext) : base(dbContext)
		{
		}

			/// <summary>
			/// METODO RESPONSAVEL POR RETORNAR O LOGIN DO USUARIO
			/// </summary>
			/// <param name="name">NOME DO USUARIO</param>
			/// <param name="pwd">SENHA DO USUARIO</param>
			/// <returns></returns>

			public async Task<Login> GetLoginAsync(string name, string pwd)
			{
				try
				{
					return await _dbContext.QueryLogin
						.Where(x => x.LGN_LOGIN.Equals(name) && x.LGN_SENHA.Equals(pwd)).FirstOrDefaultAsync();
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}


			/// <summary>
			/// METODO RESPONSAVEL POR PERSISTIR O LOGIN DO USUARIO
			/// </summary>
			/// <param name="login">OBJETO LOGIN</param>
			/// <returns>OBJETO LOGIN</returns>

			public async Task<Login> PostLoginAsync(Login login)
			{
				try
				{
					_dbContext.Add(login);
					await _dbContext.SaveChangesAsync();
					return login;
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}

			/// <summary>
			/// METODO RESPONSAVEL POR ATUALIZAR O LOGIN DO USUARIO
			/// </summary>
			/// <param name="login">OBJETO LOGIN</param>
			/// <returns>OBJETO LOGIN</returns>
			/// 

			public async Task<Login> PutLoginAsync(Login login)
			{
				try
				{
					_dbContext.SetModified(login);
					await _dbContext.SaveChangesAsync();
					return login;
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}
	}
