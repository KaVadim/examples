// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5


Console.Clear();
System.Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"число - {number}");
int digit2 = (number%100)/10;
Console.WriteLine($"число {digit2}");


