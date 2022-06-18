// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Hello, World!");

IFileModifier fileModifier = new FileModifier();

fileModifier = new FileStartModifierDecorator(fileModifier);

fileModifier = new WaveModifierDecorator(fileModifier);

fileModifier.WriteToFile("C:\\Users\\Yevhen\\Documents\\test.txt", "test line" + Environment.NewLine);
