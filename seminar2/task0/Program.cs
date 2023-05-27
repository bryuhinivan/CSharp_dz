// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
// 78 -> 8, 12 -> 2, 85 -> 8

/*int number = new Random().Next(10, 100);
int firstNumber = number / 10; // деление нацело 78 = 7
int secondNumber = number % 10; // вычисление последней цифры 78 = 8
Console.WriteLine("Рандомное число: " + number);
Console.WriteLine(firstNumber);
Console.WriteLine(secondNumber);

if (firstNumber > secondNumber)
{
    Console.WriteLine("Первая цифра больше второй");
}
else if(secondNumber > firstNumber)
{
    Console.WriteLine("Вторая цифра больше первой");
}
else
{
    Console.WriteLine("Цифры равны");
}*/

void FindLargestDigit(int num)
{
    int firstNumber = num / 10;
    int secondNumber = num % 10;
    Console.WriteLine("Рандомное число: " + num);
    Console.WriteLine(firstNumber);
    Console.WriteLine(secondNumber);
    if (firstNumber > secondNumber)
    {
        Console.WriteLine("Первая цифра больше второй");
    }
    else if(secondNumber > firstNumber)
    {
        Console.WriteLine("Вторая цифра больше первой");
    }
    else
    {
        Console.WriteLine("Цифры равны");
    }
}
int number = new Random().Next(10, 100);
int number1 = new Random().Next(100);
int number2 = new Random().Next(-80, 10);
FindLargestDigit(number);
FindLargestDigit(number1);
FindLargestDigit(number2);

