using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        Regex pattern = new Regex(@"(\w*)рыб(\w*)");
        Regex strBeginPattern = new Regex(@"^Мног\w*");
        Regex strEndPattern = new Regex(@"\w*ять\?$");
        Regex replacePattern = new Regex(@"\w*bober kurwa\w*");

       
      

        string text = File.ReadAllText("text.txt");
        

        

        string[] lines = File.ReadAllLines("text.txt");


        foreach (string line in lines)
        {
            if(strBeginPattern.IsMatch(line))
            {
                Console.WriteLine(line);
            }
            if(strEndPattern.IsMatch(line))
            {
                Console.WriteLine(line);
            }
        }

        Console.WriteLine(pattern.Matches(text).Count);
        

        StreamWriter writer = new StreamWriter("text.txt", false);

        writer.Write(replacePattern.Replace(text, "Lorem Ipsum"));
        writer.Close();
        

       
        
    }
}
