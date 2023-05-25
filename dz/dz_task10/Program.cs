// Задача 10. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5, 782 -> 8, 918 -> 1

void FindSecondNumber(int num)
Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine("Случайное трёхзначное число: " + number);

int numA = num / 10;
Console.WriteLine("Первые две цифры из трёхзначного числа: " + numberA);

double numB = numA % 10;
Console.WriteLine("Вторая цифра трёхзначного числа: " + numberB);

FindSecondNumber(numB);