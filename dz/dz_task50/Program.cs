// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец

Console.Clear();

int numberRows = Prompt("Введите номер строки массива: ");
int numberColumns = Prompt("Введите номер столбца массива: ");
int [,] massiv = new int [6, 6];
GetRandomMassiv(massiv);
PositionNumberInMassiv(numberRows, numberColumns);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void GetRandomMassiv(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++) // GetLength(0) отвечает за строки 
    {
        for (int j = 0; j < array.GetLength(1); j++) // GetLength(1) отвечает за столбцы
        {
            array[i, j] = new Random().Next(-9, 10);
            Console.Write($"{array[i, j]} |\t"); // разграничиваем значения вертикальным слешем |\t
        }
        Console.WriteLine('\n'); // '\n' перевод строки
    }
}
void PositionNumberInMassiv(int rows, int columns)
{
    if (rows < massiv.GetLength(0) && columns < massiv.GetLength(1))
    {
        Console.WriteLine($"Число из массива на пересечении строки {rows} и столбца {columns} равно: {massiv[rows, columns]}");
    }
    else 
    {
        Console.WriteLine($"Число в массиве на пересечении строки {rows} и столбца {columns} отсутствует");
    }
}
