// Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int num = Prompt ("Введите число N: ");
int Prompt (string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int i = 1;

while (i <= num)
{
    Console.Write(i*i*i + " ");
    i++;
}





