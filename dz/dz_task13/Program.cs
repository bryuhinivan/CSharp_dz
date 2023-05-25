// Задача 13. Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.Clear();

Console.Write("Введите число от 1 до 99999: ");
double number = double.Parse(Console.ReadLine()!);

if (number < 99)
Console.WriteLine("Третьей цифры нет");
if (number >= 100)
{
double numberA = number % 10;
Console.WriteLine("Третья цифра трёхзначного числа: " + numberA);
}
/*{
    if (99 < number < 999)
    {
        double numberA = number / 10;
        double numberB = numberA % 10;
        Console.WriteLine("Третья цифра трёхзначного числа");
    }
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}*/



