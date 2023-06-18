// Задача 67. Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите: ");
        value = Console.ReadLine();
    }
    // Console.Clear();
    return val;
}

int number = Prompt("Введиче число: ");

int Summ(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number%10+Summ(number/10);
    

}

Console.Write(Summ(number));