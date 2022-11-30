// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


Console.Clear();
Console.Write("Введите длину массива ");
int dl = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Это созданный массив из {dl} элементов и он же наоборот ");
int [] arr = new int [dl];
for (int i=0; i<arr.Length; i++)
{
    arr[i] = new Random().Next(-100,100);
    Console.Write($" {arr[i]}");
    Console.WriteLine($" {-arr[i]}");
}
//Console.Write($" Это массив наоборот из {dl} элементов {arr[i]=arr[i]*(-1)}");

