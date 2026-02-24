// See https://aka.ms/new-console-template for more information
namespace ConsoleApp1;

internal class Program
{
    static void Hello()
    {
        Console.WriteLine("HelloWorld");
    }
    static void Main()
    {
        Hallo tst;
        tst = Hello;
        tst();
        
        
    }

    delegate void Hallo();
}
