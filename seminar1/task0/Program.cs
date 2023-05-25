// Напишите программу, которая на вход принимает рандомное число и выдаёт его квадрат (число умноженное само на себя).

// Например: 
// 4 -> 16
// -3 -> 9
// -7 -> 49

/*Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int result = number * number;
Console.WriteLine("Квадрат числа равен = " + result + ".");*/

Console.Clear();

int number = new Random().Next(1, 1000);
Console.WriteLine("Случайное рандомное число: " + number);
int result = number * number;
Console.WriteLine("Квадрат числа равен = " + result);






