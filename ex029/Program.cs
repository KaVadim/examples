// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.Write("Введите длину массива ");
int dl = Convert.ToInt32(Console.ReadLine());

Console.Write($"Это массив из {dl} рандомных элементов: ");
int [] arr = new int [dl];
for (int i=0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,100); 
    Console.Write(" " + arr[i]);
}

// int[] arr = new int [5];                             Это для ручного ввода массива
// for(int i = 0; i < arr.Length; i++)
// {
// arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine(string.Join(", ", arr));