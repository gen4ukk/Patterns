namespace Bridge
{
    internal abstract class AbstractReport
    {
        protected readonly IPrinter _printer;
        protected string _body; 

        public AbstractReport(IPrinter printer)
        {
            _printer = printer;
        }

        public abstract void MakeReport(string text);

        public void Print() 
        {
            _printer.Print(_body);
        }
    }
}