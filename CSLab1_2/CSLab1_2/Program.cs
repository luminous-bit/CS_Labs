using System;
using CSLab1_2;
class Program
{
    static void Main(string[] args)
    {
        Printer europeanPrinter = new EUPrinter();
        Printer americanPrinter = new USPrinter();

        Printer decoratedEUPrinter = new PostDecorator(new PreDecorator(europeanPrinter, "European ||  "), "   ||");
        Printer decoratedUSPrinter = new PostDecorator(new PreDecorator(americanPrinter, "American >>  "), " <<");

        Console.WriteLine("European Style: " + decoratedEUPrinter.Print());
        Console.WriteLine("\nAmerican Style: " + decoratedUSPrinter.Print());
    }
}
