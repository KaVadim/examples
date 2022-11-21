// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5


Console.Clear();
System.Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (99 < number  && number < 1000)
    {
    int digit2 = (number%100)/10;
    Console.WriteLine($"число по середине {digit2}");
    }
    else 
    Console.WriteLine("число не трехзначное");

