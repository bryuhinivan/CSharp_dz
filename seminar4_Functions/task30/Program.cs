// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// =================Рабочая программа
/*Console.Clear();

int [] array = new int [8];
 for (int i = 0; i < array.Length; i++)
 {
    array [i] = new Random().Next(0, 2); // генератор [a, b)
    Console.Write(array[i] + " ");
 }
*/ 



// =================Рабочая программа обёрнутая в метод
Console.Clear();

void RandomMassive()
{
    int [] array = new int [8];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(0, 2); // генератор [a, b)
        Console.Write(array[i] + " ");
    }
}
RandomMassive();
