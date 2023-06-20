// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();
int m = Prompt("Введите неотрицательное число m: ");
int n = Prompt("Введите неотрицательное число n: ");
int A = FunctionAckermann(m, n);
Console.Write($"Функция Аккермана = {A} ");


int Prompt(string message) 
{
  Console.Write(message);
  int number = int.Parse(Console.ReadLine()!);
  return number;
}

// Метод мне не понятен. Алгоритм взял на просторах интернета.
int FunctionAckermann(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return FunctionAckermann(m - 1, 1);
    } 
    else 
    {
        return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
    }
}