// прога кот выводит случ-е 3хзначное число и удаляет вторую цифру этого числа

Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine($"sluchainoe chislo - {number}");
int digit1 = number/100;
int digit2 = number%10;
Console.WriteLine($"число {digit1}{digit2}");
