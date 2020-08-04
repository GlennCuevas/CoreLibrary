using Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL.Repos
{
	public class Companies
	{
		public static Company GetCompany(int id)
		{
			Company company = new Company() { Id = id, Name = "Core.DAL.Repos" };
			company.Stores = new List<Store>();
			return company;
		}
	}
}
