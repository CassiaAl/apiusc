using MeuPrimeiroProjeto.BLL.Infra;
using MeuPrimeiroProjeto.DAL;
using MeuPrimeiroProjeto.DAL.DataBaseContext;
using MeuPrimeiroProjeto.DAL.Infra;
using MeuPrimeiroProjetto.Api.UoW;
using MeuPrimeiroProjetto.Api.UoW.Infra;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace MeuPrimeiroProjetto.Api
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			//DB CONTEXT
			services.AddScoped<IMeuPrimeiroProjetoDbContext, MeuPrimeiroProjetoDbContext>();
			

			//REPOSITORY
			services.AddScoped<ILoginRepository, LoginRepository>();

			//BLL
			services.AddScoped<ILoginBLL, LoginBLL>();

			//UoW
			services.AddScoped<ILoginUoW, LoginUoW>();


			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
			//FORMATAÇAO JSON (PASCAL CASE)
			.AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
			//PASCALCASE = ExemploObjeto
			//CAMELCASE =  exemploObjeto
		} 

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())			
				app.UseDeveloperExceptionPage();
			else
				app.UseHsts();
			

			app.UseHttpsRedirection();

			app.UseCors(builder => builder
								   .AllowAnyOrigin()
								   .AllowAnyMethod()
								   .AllowAnyHeader()
								   .AllowCredentials()
					   );

			app.UseMvc();
		}
	}
}
