﻿// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0) //если остаток от деления переменной number на 2 равен нулю.
    Console.WriteLine("Число чётное");
else 
    Console.WriteLine("Число нечётное");