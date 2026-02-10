namespace ConsoleApp1;

using ClosedXML.Excel;
internal class Program
{
   
    static void Main()
    {
        using var XLBook = new XLWorkbook("C:\\Users\\Redmi\\labWorks\\LabWork3\\ConsoleApp1\\bin\\Debug\\net10.0\\Задание 6_4.xlsx");
        
        var Sheet = XLBook.Worksheet("Задание 1");

        int row = 1;

        while (!Sheet.Cell($"A{row}").IsEmpty())
        {
            Console.WriteLine($"{Sheet.Cell($"A{row}").Value}");
            ++row;
        }
    }
}