using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeuPrimeiroProjetto.Api.Controllers
{ 
    [ApiController]	
    public class ValuesController : ControllerBase
    {
		[Route ("Api/values/name")]
		public IActionResult GetName(string name)
		{
			try
			{
				return Ok(name + " Você está matriculado no curso de Pós-Graduação em Engenharia de Software");
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
    }
}