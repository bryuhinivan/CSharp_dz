// Задача 8. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число N: ");
int number1 = int.Parse(Console.ReadLine()!);

int number2 = number1 * -1;
int temp = 2;

if ( number1 > 2)
    {
    while (temp <= number1)
        {
        Console.Write(temp + " ");
        temp += 2;
        }
    }
else
    {
    Console.Write("Вы ввели слишком маленькое начение");
    }