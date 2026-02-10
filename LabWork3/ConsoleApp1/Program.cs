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
            Console.Write($"{Sheet.Cell(row, col).Value}\t|\t");
            ++col;
            if (Sheet.Cell(row, col).IsEmpty())
            {
                ++row;
                col = 1;
                Console.Write("\n");
                if (Sheet.Cell(row, col).IsEmpty())
                {
                    break;
                }
            }
        }
    }
}