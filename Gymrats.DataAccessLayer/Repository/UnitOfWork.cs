using Gymrats.DataAccessLayer.Data;
using Gymrats.DataAccessLayer.Repository.IRepository;
using Gymrats.Models.Customer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Gymrats.DataAccessLayer.Repository
{
	public	class UnitOfWork : IUnitOfWork
	{
		private ApplicationDbContext _db;

		public UnitOfWork(ApplicationDbContext db)
		{
			_db = db;
			Users = new UserRepository(_db);

		}

		public IUserRepository Users { get; private set; }

		public void Save()
		{
			_db.SaveChanges();
		}
	}
}
