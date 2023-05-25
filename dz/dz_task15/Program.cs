// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да, 7 -> да, 1 -> нет

Console.Clear();

Console.Write("Введите число от 1 до 7: ");
int weekDay = int.Parse(Console.ReadLine()!);
if (weekDay == 1)
{
Console.WriteLine("рабочий день");
}
if (weekDay == 2)
{
Console.WriteLine("рабочий день");
}
if (weekDay == 3)
{
Console.WriteLine("рабочий день");
}
if (weekDay == 4)
{
Console.WriteLine("рабочий день");
}
if (weekDay == 5)
{
Console.WriteLine("рабочий день");
}
if (weekDay == 6)
{
Console.WriteLine("выходной день");
}
if (weekDay == 7)
{
Console.WriteLine("выходной день");
}