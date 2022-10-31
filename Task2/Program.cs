// See https://aka.ms/new-console-template for more information
//Задача 2: Напишите программу, которая на вход принимает два числа и
//выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7->max = 7
//a = 2 b = 10->max = 10
//a = -9 b = -3->max = -3
Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Давай помогу тебе узнать какое из двух числе больше.");
Console.WriteLine("Введи первое число: ");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int b = Convert.ToInt32(Console.ReadLine()!);
if (a > b)
{ Console.WriteLine("Первое число " + a + " больше второго числа " + b); }
else if (a == b)
{ Console.WriteLine("Введенные числа равны"); }
else 
{ Console.WriteLine("Второе число " + b + " больше первого числа " + a); }
