﻿// прога, кот принимает число и выдает кол-во цифр в числе
// 456 - 3

Console.Write ("Введите число ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine())); //  мат.абс. позволяет вводить отрицательные числа
int count =0; // это будет счетчиком при делении числа на 10
if(num !=0) // != - "не равно"
{
    while (num>0)
    {
        count++;
        num=num/10;
    }
}
else 
{
    count=1;
}
Console.WriteLine($" Количество цифр в числе " +count);