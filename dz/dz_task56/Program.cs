// Задача 56. Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int rows = Prompt("Введите количество строк в массиве: ");
int columns = Prompt("Введите количество столбцов в массиве: ");
// if (rows == columns) Console.WriteLine($"Количество строк и столбцов не должны совпадать, но мы продолжим:)");
// Квадрат, это тоже прямоуголник, у которого все стороны равны.
int [,] array = GetArray (rows, columns, 0, 10);
PrintArray(array);
SumNumbersRows(array, 0);

int minSumRow = 0;
int sumRow = SumNumbersRows(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumNumbersRows(array, i);
    if (sumRow > tempSumLine)
    {
    sumRow = tempSumLine;
    minSumRow = i;
    }
}
Console.WriteLine($"\nВ строке № {minSumRow + 1} наименьшая сумма чисел, которая равна: {sumRow}");

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int [,] GetArray(int m, int n, int minValue, int maxValue)
{
    int [,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    } 
    return result;
}

void PrintArray (int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");           
        }
        Console.WriteLine();
    }
}

int SumNumbersRows(int [,] inArray, int i)
{
    int sumRows = inArray[i,0];
    for (int j = 1; j < inArray.GetLength(1); j++)
    {
        sumRows = sumRows + array[i,j];
    }
    return sumRows;
}
