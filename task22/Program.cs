// прога, кот принимает число N и выдает таблицу квадратов чисел от 1 до N
// 5 - 1?4/9?16/25
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= num; i++)
{
    Console.WriteLine(Math.Pow(i,2)); // или i*i
}
