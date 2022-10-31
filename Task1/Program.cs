// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Давай проверим является ли одно число квадратом другого.");
Console.WriteLine("Введи первое число: ");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введи второе число, которое надо проверить является ли квадратом первого числа: ");
int b = Convert.ToInt32(Console.ReadLine()!);
int result = a * a;
if (result == b)
{
    Console.WriteLine($"Второе число {b} является квадратом первого числа {a}");
}
else
{
    Console.WriteLine($"Второе число {b} не является квадратом первого числа {a}");
}

