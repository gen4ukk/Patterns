namespace Visitor
{
    internal abstract class Product2
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }

        public abstract void Accept(Visitor2 visitor);
    }

    internal class Phone2 : Product2
    {
        public Phone2()
        {
            Name = "iphone";
            Cost = 999;
            Description = $"buy me. My name is {Name}. I cost {Cost}";
        }

        public override void Accept(Visitor2 visitor)
        {
            visitor.VisitPhone(this);
        }
    }

    internal class Laptop2 : Product2
    {
        public Laptop2()
        {
            Name = "ryzen";
            Cost = 2999;
            Description = $"buy me. My name is {Name}. I am new. I cost {Cost}";
        }

        public override void Accept(Visitor2 visitor)
        {
            visitor.VisitLaptop(this);
        }
    }
}
