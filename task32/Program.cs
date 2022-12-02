// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


Console.Clear(); // мой вариант
Console.Write("Введите длину массива ");
int dl = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Это созданный массив из {dl} элементов и он же наоборот ");
int [] arr = new int [dl];
for (int i=0; i<arr.Length; i++)
{
    arr[i] = new Random().Next(-100,100);
    Console.Write($" {arr[i]}");
    Console.WriteLine($" {-arr[i]}");
} // 


int[] FillArray(int size) // вариант из семинара
{
int[] arr = new int[size];
for(int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(-9,10);
}
return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine("Ваш массив:"+ string.Join(" ",array));
for(int i = 0; i < array.Length; i++)
{
array[i]*=-1;
}
Console.WriteLine("Новый массив:"+ string.Join(" ",array)); //