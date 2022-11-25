// прога, кот принимает координаты 2 точек и находит расстояние между ними
// а (3,6), б (2,1) ---- 5, 09


Console.WriteLine ("Введите координату Х точки А: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату У точки А: ");
int Ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату Х точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату У точки B: ");
int By = Convert.ToInt32(Console.ReadLine());

double dist = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax,2) + Math.Pow(By - Ay,2)),3); //sqrt
Console.WriteLine(dist);
