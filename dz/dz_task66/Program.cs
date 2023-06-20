// Задача 66. Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int number1 = Prompt("Введите 1 число: ");
int number2 = Prompt("Введите 2 число: ");
SummNaturalNumber(number1,number2, 0);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void SummNaturalNumber (int number1,int number2, int sum)
{
    if (number1 > number2)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от 1-го числа до 2-го числа: {sum}");
        return;
    }
    sum = sum + (number1++);
    SummNaturalNumber (number1, number2, sum);
}
