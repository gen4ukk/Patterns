namespace FactoryMethodPattern
{
    internal class ConnectionFactory : AbstractConnectionFactory
    {

        public override IConnection CreateConnection()
        {
            IConnection connection = null;

            switch (DBConfig.DBType)
            {
                case "Oracle":
                    connection = new OracleConnection(DBConfig.DBConnection);
                    break;

                case "MSSQL":
                    connection = new MsSqlConnection(DBConfig.DBConnection);
                    break;

                default:
                    throw new ArgumentException($@"DBType {DBConfig.DBType} not found");
            };

            return connection;
        }
    }
}
