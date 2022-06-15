using FactoryMethodPattern;

Console.WriteLine("Hello, World!");

IConnection connection = new ConnectionFactory().CreateConnection();

connection.Execute("DROP DB");
