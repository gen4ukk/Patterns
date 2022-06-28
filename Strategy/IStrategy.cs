namespace Strategy
{
    internal interface IStrategy
    {
        void Display(string text);
    }

    internal class ConsoleStrategy : IStrategy
    {
        public void Display(string text)
        {
            Console.WriteLine(text);
        }
    }

    internal class FileStrategy : IStrategy
    {
        public void Display(string text)
        {
            File.WriteAllText("D:\\1.txt", text);
        }
    }

    internal class TextSaverManager 
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy) 
        {
            _strategy = strategy;
        }

        public void Display(string text)
        {
            _strategy.Display(text);
        }
    }
}
