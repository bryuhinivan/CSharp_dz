// Задача 35. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);

    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void ExamArr (int[] arr)
{
    int exam = 0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]>10 && arr[i]<99)
        {
        exam ++;
        // Console.WriteLine($"Такое число есть под номером {i+1} ");
        }
    }
    if (exam == 0)
        {
        Console.WriteLine($"Таких чисел нет в массиве ");
        }
    else
    {
        Console.WriteLine($"Количество таких элементов в массиве равно: {exam} ");
    }    
}

int[] array = GetArray(123, 0, 200);
PrintArray(array);
Console.WriteLine($"");
ExamArr(array);