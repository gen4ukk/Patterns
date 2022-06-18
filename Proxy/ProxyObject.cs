namespace Proxy
{
    internal class ProxyObject : IExternalInterface
    {
        private IExternalInterface _externalInterface;

        public bool CheckSomeData()
        {
            if (_externalInterface == null)
            {
                _externalInterface = new ExternalImplementation();
            }

            return _externalInterface.CheckSomeData();
        }

        void IExternalInterface.DeleteSomeData()
        {
            
        }

        public int DoSomeWork()
        {
            if (_externalInterface == null)
            {
                _externalInterface = new ExternalImplementation();
            }

            return _externalInterface.DoSomeWork();
        }
    }
}
