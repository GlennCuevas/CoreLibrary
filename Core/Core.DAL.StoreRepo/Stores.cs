using Core.Database;
using Core.Objects;

namespace Core.DAL.Repos
{
	public class Stores
	{
		public static Store GetStore(int id)
		{
			System.Diagnostics.Debug.WriteLine("Dependency on Core.Database " + Connection.Test);
			return new Store() { ID = id, Name = "Dependency on Core.Objects" };
		}
	}
}
