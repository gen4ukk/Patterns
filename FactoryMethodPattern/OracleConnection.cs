namespace FactoryMethodPattern
{
    internal class OracleConnection : IConnection
    {
        public string ConnectionString { get; set; }

        public OracleConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Execute(string script)
        {
            Console.WriteLine($@"Oracle Executing script '{script}'");
        }
    }
}
