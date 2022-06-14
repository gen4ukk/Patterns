namespace BuilderPattern
{
    internal class Robot : IProduct
    {
        List<string> _partsList = new List<string>();
        public void AddPart(string part)
        {
            _partsList.Add(part);
        }

        public void Show()
        {
            foreach (var item in _partsList)
            {
                Console.Write(item);
                Console.Write(Environment.NewLine);
            }
        }
    }
}
