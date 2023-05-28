// Задача 22. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

/*Console.Clear();
int number = Prompt("Введите число: ");
PrintDegreTable(number);

int Prompt(String message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()); ;
}

void PrintDegreTable(int number)
{
for (int i = 1; i <= number; i++)
{
Console.Write(Math.Pow(i, 2) + " ");
}
}*/

/*int num = Prompt ("Введите число N: ");

int Prompt (string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int i = 1;

while (i <= num)
{
    Console.Write(i*i + " ");
    i++;
}*/


Console.Clear();
int Prompt (string message) {
Console.Write(message);
string num = Console.ReadLine()!;

if ((int.TryParse(num, out int num_n)) == false) {
Console.WriteLine("Это не число!");
}

return num_n;
}

void PrintDegreTable(int number)
{
for (int i = 1; i <= number; i++)
{
Console.Write(Math.Pow(i, 2) + " ");
}
}

int num = Prompt ("Введите число N: ");

// Определение числа по модулю
int number = Math.Abs(num);

PrintDegreTable(number);