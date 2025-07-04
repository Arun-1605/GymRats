using Gymrats.DataAccessLayer.Data;
using Gymrats.DataAccessLayer.Repository.IRepository;
using Gymrats.Models.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymrats.DataAccessLayer.Repository
{
	public class UserRepository : Repository<Users> , IUserRepository
	{
		private ApplicationDbContext _db;

		public UserRepository(ApplicationDbContext db) : base(db)
		{
			_db= db;
		}

		public void Update(Users user)
		{
			_db.Users.Update(user);
		}


	}
}
