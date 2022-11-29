// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
Console.Write("Введите число ");
int i = Convert.ToInt32(Console.ReadLine());
int num = 0;
for (int count=1; i>0; count++)
    {
    num = num + i%10;
        i = i/10;
    }
 Console.Write($"Сумма цифр в числе равна - {num}");