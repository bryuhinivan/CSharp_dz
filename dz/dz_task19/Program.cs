// Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




// Рабочая программа с методами

// Метод FindLastDigit находит последнюю цифру заданного числа
int FindLastDigit (int AAAAA) // AAAAA - пятизначное число
{
    int num = AAAAA % 10;
    return num;
}

// Метод NumberToPoint определяет число, которое осталось после отсечения последней цифры
int NumberToPoint (int BBBB) // BBBB - число после отсечения последней цифры
{
    BBBB = BBBB / 10;
    return BBBB;
}

// Метод FindPalindrome сравнивает первые две цифры и последние 2 цифры пятизначного числа
// и определяет является ли заданное число полиндромом.
void FindPalindrome(int num0, int num4, int num1, int num3)
{
if (num0 == num4 && num1 == num3)
    {
    Console.WriteLine("Число является палиндромом");
    }
else
    {
    Console.WriteLine("Число не является палиндромом");
    }
}

Console.Clear(); 

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

int num4 = FindLastDigit(num);
int numA = NumberToPoint(num);

int num3 = FindLastDigit(numA);
int numB = NumberToPoint(numA);

int num2 = FindLastDigit(numB);
int numC = NumberToPoint(numB);

int num1 = FindLastDigit(numC);
int numD = NumberToPoint(numC);

int num0 = FindLastDigit(numD);

Console.WriteLine($"{num} {numA} {numB} {numC} {numD}"); // команда выводит на экран все переменные
FindPalindrome(num0, num4, num1, num3);




// Рабочая программа без методов
/*
Console.Clear();

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

int num4 = num % 10; // нашли 5-ую цифру пятизначного числа и записали её в переменную num4
int numA = num / 10; // первые 4 цифры пятизначного числа

int num3 = numA % 10; // нашли 4-ую цифру пятизначного числа и записали её в переменную num3
int numB = numA / 10; // первые 3 цифры пятизначного числа 

int num2 = numB % 10; // нашли 3-ию цифру пятизначного числа и записали её в переменную num2
int numC = numB / 10; // первые 2 цифры пятизначного числа

int num1 = numC % 10; // нашли 2-ую цифру пятизначного числа и записали её в переменную num1
int numD = numC / 10; // первая цифра пятизначного числа 

int num0 = numD % 10; // нашли 1-ую цифру пятизначного числа и записали её в переменную num0


//Console.WriteLine($"{num0} {num1} {num2} {num3} {num4}"); // команда выводит на экран все переменные

if (num0 == num4 && num1 == num3)
    {
    Console.WriteLine("Число является палиндромом");
    }
else
    {
    Console.WriteLine("Число не является палиндромом");
    }
*/