//прога кот выводит случайное число из отрезка (10,99) и показывает
// наибольшую цифру числа
// 78 -- 8

Console.Clear();
int number = new Random().Next(10, 100);
Console.WriteLine($"sluchainoe chislo - {number}");
int digit1 = number/10;
int digit2 = number%10;
if (digit1 > digit2)
{
    Console.WriteLine($"naibolshee chislo v {number} eto {digit1}");
}
else
    Console.WriteLine($"naibolshee chislo v {number} eto {digit2}");