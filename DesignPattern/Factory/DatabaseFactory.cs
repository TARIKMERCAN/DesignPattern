namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase? CreateDatabase(DatabaseType dbType)
        {
            if (dbType == DatabaseType.SqlServer)
            {
                return new SqlServerDatabase();
            }
            else if (dbType == DatabaseType.Oracle)
            {
                return new OracleDatabase();
            }
            else
            {
                Console.WriteLine("ERROR!, Invalid type of database.");
                return null;
            }
        }
    }
}

