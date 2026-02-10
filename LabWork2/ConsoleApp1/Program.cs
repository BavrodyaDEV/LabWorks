// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1;
internal class Program
{
   
    static void Main()
    {
        List<int> nums = new List<int>();
        Console.WriteLine("Введите длину массива: ");
        int len = Convert.ToInt32(Console.ReadLine());
        
        
        for(int i = 0; i < len; i++)
        {
            Console.Write("Введите число: ");
            nums.Add(Convert.ToInt32(Console.ReadLine()));


        }
        
        List<int> sorted = nums;
        sorted.Sort();

        foreach (int x in sorted)
        {
            Console.Write($"{x} ");
        }
        Console.WriteLine("");

        sorted.Reverse();

        foreach (int x in sorted)
        {
            Console.Write($"{x} ");
        }
        Console.WriteLine("");


        
    }
}
