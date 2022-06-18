namespace Proxy
{
    internal class ExternalImplementation : IExternalInterface
    {
        public bool CheckSomeData()
        {
            return true;
        }

        public void DeleteSomeData()
        {
            throw new NotImplementedException();
        }

        public int DoSomeWork()
        {
            return 0;
        }
    }
}
