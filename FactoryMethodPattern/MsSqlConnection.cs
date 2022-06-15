namespace FactoryMethodPattern
{
    internal class MsSqlConnection : IConnection
    {
        public string ConnectionString { get; set; }

        public MsSqlConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Execute(string script)
        {
            Console.WriteLine($@"MSSQL Executing script '{script}'");
        }
    }
}
