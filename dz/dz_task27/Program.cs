// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// =====Рабочая программа, но только для пятизначного числа не обёрнутая в метод

/*Console.Clear();

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int num = Prompt("Введите любое число: ");

int num4 = num % 10; // нашли 5-ую цифру пятизначного числа и записали её в переменную num4
int numA = num / 10; // первые 4 цифры пятизначного числа

int num3 = numA % 10; // нашли 4-ую цифру пятизначного числа и записали её в переменную num3
int numB = numA / 10; // первые 3 цифры пятизначного числа 

int num2 = numB % 10; // нашли 3-ию цифру пятизначного числа и записали её в переменную num2
int numC = numB / 10; // первые 2 цифры пятизначного числа

int num1 = numC % 10; // нашли 2-ую цифру пятизначного числа и записали её в переменную num1
int numD = numC / 10; // первая цифра пятизначного числа 

int num0 = numD % 10; // нашли 1-ую цифру пятизначного числа и записали её в переменную num0

// Console.WriteLine($"{num0} {num1} {num2} {num3} {num4}"); // команда выводит на экран все переменные

int numsumm = num0 + num1 + num2 + num3 + num4;
Console.WriteLine ("Сумма пятизначного числа: " + numsumm);*/

//=====Рабочая программа с использованием методов.

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Summnumber(int number)
{
    int sum = 0;
    for (int i = 0; number > 0; i++)
    {
    int digit = number % 10;
    Console.Write(digit + " ");
    sum = sum + digit;
    number = number / 10;
    }
    return sum;
}

Console.Clear();
int num = Prompt("Введите любое число: ");
int sumnum = Summnumber(num);
Console.WriteLine("Сумма всех чисел равна: " + sumnum);


    
