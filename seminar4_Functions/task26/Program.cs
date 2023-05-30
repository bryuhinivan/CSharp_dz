// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

string mess = "Введите число: ";
int num = Prompt(mess);
Console.Write($"Кол-во цифр в числе = {GetSumNums(num)}");

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int GetSumNums(int number)
{
    int count = 0; //количество цифр в числе
    while (number > 0)
    {
        number /= 10; // A = A/10
        count++;
    }
    return count;
}

