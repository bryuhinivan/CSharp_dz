// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int[] GetArray(int size, int minValue, int maxValue) // Метод определяет массив, который приходит из строки 38
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
void PrintArray(int[] arr) // // Метод выводит в терминал весь массив
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
void CountEvenNumMassiv(int[] array) // Метод определяет количество чётных чисел в массиве и выводит количество в терминал
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine ($"Количество четных чисел в массиве равно: {count} ");
}

Console.Clear();
int[] array = GetArray(4, 100, 1000);
PrintArray(array);
CountEvenNumMassiv(array);



