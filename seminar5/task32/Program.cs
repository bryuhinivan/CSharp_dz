// Задача 32. Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

int [] array = GetArray(4, -10, 10);
PrintArray (array);

// foreach (int el in array)
// {
//         el= el*-1;
// }

for (int i = 0; i<array.Length; i++)
{
    array[i]= array[i]*-1;
}

Console.WriteLine();
PrintArray (array);