// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.Clear();
string mess = "Введите число: ";
int num = Prompt(mess);
//int summ = GetSumNums(num);
Console.WriteLine($"Сумма равна = {GetSumNums(num)}");


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int GetSumNums(int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
        Console.Write(sum + " ");
    }
    return sum;
}