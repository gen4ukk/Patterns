using System.Text.Json;

namespace FactoryMethodPattern
{
    internal abstract class AbstractConnectionFactory
    {
        public AbstractConnectionFactory()
        {
            Init();
        }

        public DBConfig DBConfig { get; set; }
        public void Init() 
        {
            string jsonString = File.ReadAllText("config.json");
            DBConfig = JsonSerializer.Deserialize<DBConfig>(jsonString);
        }
        public abstract IConnection CreateConnection();
    }
}
