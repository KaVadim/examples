// прога, кот по номеру четверти показывает диапазон х и у


// Console.WriteLine ("Введите номер четверти (1,2,3 или 4): ");
// int x = Convert.ToInt32(Console.ReadLine());

// if (x==1 || x==2 || x==3 || x==4)
// {
// if(x == 1)
// {
//     Console.WriteLine ("х и у больше 0");
// }
// else if(x == 2)
// {
//     Console.WriteLine ("х меньше 0, у больше");
// }
// else if(x == 3)
// {
//     Console.WriteLine ("х и у меньше 0");
// }
// else if(x == 4)
// {
//     Console.WriteLine ("х больше 0, у меньше");
// }
// }
// else 
//     {Console.WriteLine ("не верно");}


string [] quarters = {  "x>0; y>0", // 0 - индекс числа
                        "x<0; y>0", // 1
                        "x<0; y<0", // 2
                        "x>0; y<0", // 3
};
Console.WriteLine ("Введите номер четверти (1,2,3 или 4): ");
int quaerter = Convert.ToInt32(Console.ReadLine());
if(quaerter >=1 && quaerter<=4)
{
    Console.WriteLine(quarters[quaerter-1]);
}
else
{
    Console.WriteLine("Такой нет");
}