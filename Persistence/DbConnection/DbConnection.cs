using System.Data;

namespace Persistence.DbConnection
{
    public class DbConnection 
    {
        public IDbConnection Connection { get; set; }

        public DbConnection(IDbConnection connection)
        {
            Connection = connection;
            EnsureDbConnectionIsOpen();
        }

        private void EnsureDbConnectionIsOpen()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
    }
}
