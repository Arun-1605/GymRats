using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymrats.DataAccessLayer.Repository.IRepository
{
	public interface IUnitOfWork
	{
		IUserRepository Users { get; }

		void Save();
	}
}
