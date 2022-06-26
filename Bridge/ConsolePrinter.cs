namespace Bridge
{
    internal class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine($"Console print: {text}");
        }
    }
}
