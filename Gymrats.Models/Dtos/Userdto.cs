using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymrats.Models.Dtos
{
	public class Userdto
	{
			public int Id { get; set; } // Required to identify the user

			public string? Name { get; set; }
			public string? Email { get; set; }
			public string? PhoneNumber { get; set; }
			public int NoofMonths { get; set; }
			public DateTime? LastFeePaidTime { get; set; }
			
			

	}
}
