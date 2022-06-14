namespace BuilderPattern
{
    internal interface IBuilder
    {
        IBuilder AddHead();
        IBuilder AddNeck();
        IBuilder AddHands();
        IBuilder AddBody();
        IBuilder AddLegs();
        IBuilder AddBoots();
        IProduct CreateProduct();
    }
}
