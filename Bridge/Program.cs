// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Hello, World!");

AbstractReport report = new UnpivotReport(new ConsolePrinter());

report.MakeReport("tra ta ta ta");

report.Print();
