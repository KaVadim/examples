// прога кот будет принимать 2 числа и выводить, является ли 2-е число кратным 1-му
// если 2 не кратно 1, то программа выводит остаток от деления

Console.Clear();
System.Console.Write("Введите первое число ");
int digit1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число ");
int digit2 = Convert.ToInt32(Console.ReadLine());

if  (digit2%digit1==0) {
    Console.WriteLine("числа кратные");
}
else {
int ostatok = digit2%digit1;
Console.WriteLine($"остаток {ostatok}");
}