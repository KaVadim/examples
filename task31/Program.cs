// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

int[] FillArray(int size)                   // функция, кот заполняет рандомными числами
{           // нужна будет во всех задачах этого семинара
int[] arr = new int[size];          //
for(int i = 0; i < arr.Length; i++) // создается массив, .lenght - дает длинну массива
{
arr[i] = new Random().Next(-9,10); // рандом
}
return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());  // длина массива, кот ввели переходит в сайз
int[] array = FillArray(num); // тут вызывается та функция непосредственно в самом коде
int sumPositive = 0; // лучше присваивать, чтобы в ячейках не было хламаа из памяти
int sumNegative = 0;
Console.WriteLine(string.Join(", ", array));
for(int i = 0; i < array.Length; i++)
{
if(array[i] > 0) // цикл прохода по всем элементам массива с проверкой на положительность
{
sumPositive+=array[i]; 
}
else
{
sumNegative+=array[i];
}
}
Console.WriteLine($"Сумма положительных чисел = {sumPositive}, сумма отрицательных чисел = {sumNegative}");