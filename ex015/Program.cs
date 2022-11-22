Console.Clear();
int number = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(number));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Выходной");
        }
        else
        {
            Console.Write("Рабочий");
        }
    }
    else
    {
        Console.Write("число не верно");
    }
    return " ";
}