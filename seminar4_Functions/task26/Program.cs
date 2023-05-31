// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int CountDigit(int number)
{
    int count = 0;
    while (number !=0) // всё, что меньше или равно 0 это false
    {
        number = number / 10;
        count = count + 1;
        // Console.Write (number + " ");
        // Console.WriteLine (count + " ");
    }
    // Console.WriteLine (count);
    return count;
}

int number = Prompt ("Введите число: ");
Console.WriteLine($"Количество цифр в числе равно: {CountDigit(number)}");
