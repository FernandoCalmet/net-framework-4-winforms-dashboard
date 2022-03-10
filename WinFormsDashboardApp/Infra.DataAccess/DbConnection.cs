using System.Data.SqlClient;

namespace WinFormsDashboardApp.Infra.DataAccess
{
    public abstract class DbConnection
    {
        private readonly string connectionString;

        public DbConnection()
        {
            connectionString = @"Server=(LocalDB)\mssqllocaldb;DataBase=NorthwindStore;integrated security= true";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
