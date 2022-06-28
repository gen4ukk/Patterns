// See https://aka.ms/new-console-template for more information
using Visitor;

Console.WriteLine("Hello, World!");


Product phone = new Phone();
Product laptop = new Laptop();

List<Product> products = new List<Product>();
products.Add(phone);
products.Add(laptop);

foreach (var item in products)
{
    Console.WriteLine(item.Description);
}

phone.Accept(new Promotion());
laptop.Accept(new Promotion());

foreach (var item in products)
{
    Console.WriteLine(item.Description);
}


Console.WriteLine("_________________________________");

Product2 phone2 = new Phone2();
Product2 laptop2 = new Laptop2();

List<Product2> products2 = new List<Product2>();
products2.Add(phone2);
products2.Add(laptop2);

foreach (var item in products2)
{
    Console.WriteLine(item.Description);
}

foreach (var item in products2)
{
    item.Accept(new Promotion2());
    Console.WriteLine(item.Description);
}