namespace Persistence
{
    public abstract class BaseRepository
    {
        public DbConnection Connection;

        public BaseRepository(DbConnection dbConnection)
        {
            Connection = dbConnection;
        }
    }
}
