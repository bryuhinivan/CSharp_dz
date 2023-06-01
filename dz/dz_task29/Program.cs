// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// =====Рабочая программа, которая выводит рандомный массив
// =====из 8 элементов от 0 до 999 обёрнутая в метод.

/*Console.Clear();

void RandomMassive()
{
    int [] array = new int [8];
    for (int i = 0; i < array.Length; i++)
    {
    array [i] = new Random().Next(0, 1000); // генератор [a, b)
    Console.Write(array[i] + " ");
    }
}
RandomMassive();*/

// =====Рабочая программа, которая выводит рандомный массив
// =====от 0 до 20 элементов с рандомными значениями в массиве от 0 до 999.
Console.Clear();

void RandomMassive()
{
    int [] array = new int [new Random().Next(0, 21)];
    for (int i = 0; i < array.Length; i++)
    {
    array [i] = new Random().Next(0, 1000);
    Console.Write(array[i] + " ");
    }
}
RandomMassive();