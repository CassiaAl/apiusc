using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuPrimeiroProjeto.Entities
{
	[Table ("LOGIN")]
	public class Login
	{
		[Key]
		public long LGN_IDENTI { get; set; }
		public string LGN_LOGIN { get; set; }
		public string LGN_SENHA { get; set; }
	}
}
