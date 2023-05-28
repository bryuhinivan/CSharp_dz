// Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

int num4 = num % 10;
int num3 = num4 % 10;
int num2 = num3 % 10;
int num1 = num2 % 10;
int num0 = num1 % 10;

if (num0 == num4 && num1 == num3)
    {
    Console.WriteLine("Число является палиндромом");
    }
else
    {
    Console.WriteLine("Число не является палиндромом");
    }



