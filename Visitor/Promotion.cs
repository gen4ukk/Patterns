namespace Visitor
{
    internal class Promotion : IVisitor
    {
        public void Visit(Product product)
        {
            product.Cost = (int)(product.Cost * 0.5);
            product.Description = $"PROMOTION!!! {product.Description}. New Cost is {product.Cost}";
        }
    }
}
