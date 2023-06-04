// Задача 36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);

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
void SumOdd(int[] arr)
{
    int sum = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (i % 2!=0)
        {
            sum = sum + arr[i];
        }
    }
    Console.WriteLine ();
    Console.WriteLine ($"Сумма элементов стоящих на нечётных позициях: {sum} ");
}


Console.Clear();
int[] randomMassiv = GetArray(4, 1, 11);
PrintArray (randomMassiv);
SumOdd(randomMassiv);