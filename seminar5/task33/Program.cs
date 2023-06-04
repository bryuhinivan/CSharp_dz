// Задача 33. Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


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

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

void ExamArr (int[] arr, int val)
{
    int exam = 0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]==val)
        {
        exam = 1;
        Console.WriteLine($"Такое число есть под номером {i+1} ");
        }
    }
    if (exam == 0)
        {
        Console.WriteLine($"Такого числа нет в массиве ");
        }

}

int value = Prompt("Введите искомое число: ");
int[] array = GetArray(30, -10, 10);
PrintArray(array);
ExamArr(array, value);
