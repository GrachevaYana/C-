﻿// See https://aka.ms/new-console-template for more information
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).
//4->да, - 3->нет, 7->нет
Console.WriteLine("Привет, дорогой друг!");
Console.WriteLine("Давай проверим является ли число кратно двум.");
Console.WriteLine("Введи любое число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
if (number % 2 == 0)
    { Console.WriteLine("Введенное тобой число делится без остатка на 2, а значит кратно двум."); }
else 
{ Console.WriteLine("Введенное тобой число не делится без остатка на 2."); }
