// прога, кот принимает число N и ивыдает произведение чисел от 1 до N
// факториал

Console.WriteLine("Введите число N  для определения его факториала ");
int N = Convert.ToInt32(Console.ReadLine());
int Fakt = 1;
for (int i=1; i<=N; i++)
{
    Fakt=Fakt*i;
}
Console.WriteLine($"Факториал равен " + Fakt);