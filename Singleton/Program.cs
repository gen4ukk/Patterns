// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");


var singleTon = Singleton1.Instance;

Console.WriteLine("prop value " + singleTon.MyProperty);

singleTon = Singleton1.Instance;

Console.WriteLine("prop value " + singleTon.MyProperty);

var singleTon2 = Singleton2.Instance;

Console.WriteLine("2prop value " + singleTon2.MyProperty);

singleTon2 = Singleton2.Instance;

Console.WriteLine("2prop value " + singleTon2.MyProperty);