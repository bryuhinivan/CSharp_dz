// Задача 13. Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

// Рабочая программа
/*
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    int thirdNumber = num % 10;
    System.Console.WriteLine($"Третья цифра числа -> {thirdNumber}");
}*/

// Рабочая программа с помощью метода

int number = Prompt("Введите число: ");
FindThirdNumber(number);


int Prompt (string message)
{
    Console.Clear();
    System.Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void FindThirdNumber(int num)
{
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    int thirdNumber = num % 10;
    Console.WriteLine($"Третья цифра числа -> {thirdNumber}");
}
}








