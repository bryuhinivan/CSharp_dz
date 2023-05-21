// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine(number1 + " большее число");
    Console.WriteLine(number2 + " меньшее число");
}
if (number2 > number1)
{
  Console.WriteLine(number2 + " большее число");
  Console.WriteLine(number1 + " меньшее число");
}

