//  Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Clear();
class Example
{
static void Main()
{
Console.Write("введите число ");
string username = Console.ReadLine();
    if (username[2] == 0)
    { Console.Write("числа нет"); }    
    else
    {
Console.WriteLine(" 3й символ - '{1}'",
username.Length, username[2]);}
}
}