using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymrats.Models.Customer
{
	public class Users
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public string PhoneNumber { get; set; }

		public DateTime Createddate { get; set; }

		public DateTime LastFeePaidTime { get; set; }

		public DateTime SubscriptionEndDate { get; set; }

		public DateTime SubscriptionStartDate { get; set; }

		public int NoOfMonths { get; set; }

	}
}
