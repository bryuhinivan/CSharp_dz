// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите: ");
        value = Console.ReadLine();
    }
    // Console.Clear();
    return val;
}

int number1 = Prompt("Введите 1 число: ");
int number2 = Prompt("Введите 2 число: ");

int DegreeNumber (int number1, int number2)
{
    if (number2 == 0)
    {
    return 1;
    }
    return number1*DegreeNumber(number1,number2-1);
}

Console.WriteLine(DegreeNumber (number1,number2));