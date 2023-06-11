// Задача 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string Prompt2 (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    return value;
}

void PrintArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array[i]+" ");
    }
    Console.WriteLine ();
}

int[] CreateManualArray ()
{
    int[] array = new int[1];
    int value = 0;
    string temp = string.Empty;

    for (int i=0; i<array.Length; i++)
    {        
        value = Prompt("Введите элемент массива: ");
        array[i] = value;
        temp = Prompt2("Вы хотите ввести еще число? (Y-да, N-нет): ");
        if (temp.ToLower() == "y")
        {
            Array.Resize(ref array, array.Length + 1);                        
        }
    }
    return array;
}

int[] array= CreateManualArray();
PrintArray(array);


int count = 0;
for (int i=0;i<array.Length;i++)
{
    if (array[i]>0)
    {
        count++;
    }
}
Console.WriteLine($"Положительных элементов в масиве {count}");