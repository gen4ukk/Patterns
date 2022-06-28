namespace Visitor
{
    internal abstract class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }

        public void Accept(IVisitor visiter) 
        {
            visiter.Visit(this);
        }
    }

    internal class Phone : Product
    {
        public Phone()
        {
            Name = "iphone";
            Cost = 999;
            Description = $"buy me. My name is {Name}. I cost {Cost}";
        }
    }

    internal class Laptop : Product
    {
        public Laptop()
        {
            Name = "ryzen";
            Cost = 2999;
            Description = $"buy me. My name is {Name}. I am new. I cost {Cost}";
        }
    }
}
