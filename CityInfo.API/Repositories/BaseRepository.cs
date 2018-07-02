using System;
using System.Data;
using System.Data.SqlClient;

namespace CityInfo.API.Repositories
{
	public class BaseRepository : IDisposable
    {

		protected IDbConnection connection;

        public BaseRepository()
        {
			string connectionString = "Data Source=localhost;Initial Catalog=Cities;Integrated Security=false;User ID=SA;Password=laxman123";
			connection = new SqlConnection(connectionString);

        }

		public void Dispose(){
			
		}
    }
}
