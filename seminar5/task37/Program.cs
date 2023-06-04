// Задача 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] Method(int[] array)
{
    if (array.Length % 2 == 0)
    {
        int[] res = new int[array.Length / 2];
        for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
        {
            res[i] = array[i] * array[j];
        }
        return res;
    }
    else
    {
        int[] res = new int[array.Length / 2 + 1];
        for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
        {
            res[i] = array[i] * array[j];
            if (i == j)
            {
                res[i] = array[i];
                break;
            }
        }
        return res;
    }
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + ".");
}

int[] GetArray()
{
    Console.WriteLine("size:");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] startArray = GetArray();
PrintArray(startArray);
Console.WriteLine(" ");
Console.WriteLine(" ");
int[] resArray = Method(startArray);
PrintArray(resArray);