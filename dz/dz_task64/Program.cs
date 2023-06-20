// Задача 64. Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int number = Prompt("Введите число: ");
Console.WriteLine(PrintNumber(number));

int Prompt(string message)
{
Console.Write(message);
int number = int.Parse(Console.ReadLine()!);
return number;
}

string PrintNumber(int number)
{
if (number == 1) return "1";

return $"{number}, {PrintNumber(number - 1)}";
}