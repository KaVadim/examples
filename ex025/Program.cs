// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.Clear();
Console.Write("введите число А - ");
int A = Convert.ToInt32 (Console.ReadLine());
Console.Write("введите число B - ");
int B = Convert.ToInt32 (Console.ReadLine());
// double stepen = Math.Pow (A, B);


int stepen = 1;
for (int count = 1; count <= B; count++)
    {
        stepen = stepen*A;
    }
Console.WriteLine ("А в степени В = " + stepen);
