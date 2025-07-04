using Gymrats.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymrats.DataAccessLayer.Repository.IRepository
{
	public interface IUserRepository : IRepository<Users>
	{
		void Update(Users obj);
	}
}
