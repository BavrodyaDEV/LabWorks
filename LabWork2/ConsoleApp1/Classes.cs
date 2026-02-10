
namespace ConsoleApp1;

struct Date // Структура данных о дате
{
    int day;
    int month;
    int year;

    public void SetDay(int num)
    {
        switch (month)
        {
            case 2:
                if (num > 28)
                {
                    day = 28;
                }
                else if (num < 1)
                {
                    day = 1;
                }
                else
                {
                    day = num;
                }
            break;
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                if (num > 31)
                {
                    day = 31;
                }
                else if (num < 1)
                {
                    day = 1;
                }
                else
                {
                    day = num;
                }
            break;
            default:
                if (num > 30)
                {
                    day = 31;
                }
                else if (num < 1)
                {
                    day = 1;
                }
                else
                {
                    day = num;
                }
            break;

        }
    }

    public void SetMonth(int num)
    {
        if (num > 12)
        {
            month = 12;
        }
        else if (num < 1)
        {
            month = 1;
        }
        else
        {
            month = num;
        }
    }

    public void SetYear(int num)
    {
        if(num < 1)
        {
            year = 1;
        }
        else
        {
            year = num;
        }
    }

    public int GetDay()
    {
        return day;
    }

    public int GetMonth()
    {
        return month;
    }

    public int GetYear()
    {
        return year;
    }

    public Date(int d, int m, int y)
    {
        SetYear(y);
        SetMonth(m);
        SetDay(d);
    }
}
class Math // Класс с перегрузкой функций
{
    public static void Add(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }
    public static void Add(double a, double b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    public static void Sub(int a, int b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }
    public static void Sub(double a, double b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }

    public static void Mult(int a, int b)
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }
    public static void Mult(double a, double b)
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }

    public static void Div(int a, int b)
    {
        Console.WriteLine($"{a} / {b} = {a / b}");
    }
    public static void Div(double a, double b)
    {
        Console.WriteLine($"{a} / {b} = {a / b}");
    }

    
    
    
}

class Person<T> // Класс с дженериком
{
    public string name;
    
    public T birthday;

    public Person(string nm, T bd)
    {
        if (nm == null)
        {
            name = "";

        }
        else
        {
            name = nm;
        }
        
        
        birthday = bd;
    }
    
}

class Employee : Person<Date>
{
    public string company;

    public Employee(string nm, Date dt, string comp) : base(nm, dt)
    {
        if (comp == null)
        {
            company = "";

        }
        else
        {
            company = comp;
        }
    }
    
}
