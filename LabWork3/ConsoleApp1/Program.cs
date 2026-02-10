namespace ConsoleApp1;

using ClosedXML.Excel;
internal class Program
{
   
    static void Main()
    {
        using var XLBook = new XLWorkbook("C:\\Users\\Redmi\\labWorks\\LabWork3\\ConsoleApp1\\bin\\Debug\\net10.0\\Задание 6_4.xlsx");
        
        var Sheet = XLBook.Worksheet("Задание 1");

        int row = 1;
        int col = 1;

        while (true)
        {
            Console.WriteLine($"{Sheet.Cell(row, col).Value}");
            ++row;
            if (Sheet.Cell(row, col).IsEmpty())
            {
                ++col;
                row = 1;

                if (Sheet.Cell(row, col).IsEmpty())
                {
                    break;
                }
            }
        }
    }
}