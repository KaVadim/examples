// прога, кот принимает число и выдает кол-во цифр в числе
// 456 - 3

// версия 3
Console.Clear();
Console.Write("введи число");
string? A = Console.ReadLine(); // принимает сразу строку
if (int.TryParse(A, out int num))
    Console.Write("ЦИфр " + A.Length);
else
    Console.Write("Тут не цифры");

// 2 версия
// Console.Write("Введите число ");
// int A = Convert.ToInt32(Console.ReadLine()); // число введено
// string A1 = A.ToString(); // переведет - конвертирует число. Свойства массива
// Console.Write ($"Цифр " + A1.Length);


// 1 версия
// Console.Write ("Введите число ");
// int num = Math.Abs(Convert.ToInt32(Console.ReadLine())); //  мат.абс. позволяет вводить отрицательные числа
// int count =0; // это будет счетчиком при делении числа на 10
// if(num !=0) // != - "не равно"
// {
//     while (num>0)
//     {
//         count++;
//         num=num/10;
//     }
// }
// else 
// {
//     count=1;
// }
// Console.WriteLine($" Количество цифр в числе " +count);