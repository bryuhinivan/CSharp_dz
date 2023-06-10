// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
double [,] massiv = new double [rows, columns];
PrintArray(massiv);


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number; 
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // GetLength(0) отвечает за строки 
    {
        for (int j = 0; j < array.GetLength(1); j++) // GetLength(1) отвечает за столбцы
        {
            array[i, j] = new Random().Next(-999, 1000) / 10.0;
            Console.Write($"{array[i, j]} |\t");
        }
        Console.WriteLine('\n');
    }
}

