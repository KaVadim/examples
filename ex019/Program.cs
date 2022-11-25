// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Clear();
Console.WriteLine("Введите 5 значное число ");
string number = Console.ReadLine();
int Length = number.Length;

if (Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - не палиндром");
    }
}
else
{
    Console.WriteLine($"число не пятизначное");
}