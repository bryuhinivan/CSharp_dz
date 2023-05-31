// Напишите программу, которая выводит на экран числа от 1 до 100.
// При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz»,
// а вместо чисел, кратных пяти — слово «Buzz».
// Если число кратно и 3, и 5, то программа должна выводить слово «FizzBuzz».

Console.Clear();

int value = 100;
for (int i=1; i<=value; i++)
{
if (i%3==0 && i%5==0)
{
Console.Write(" FizzBuzz ");
}
else if (i%3==0)
{
Console.Write(" Fizz ");
}
else if (i%5==0)
{
Console.Write(" Buzz ");
}
else
{
Console.Write (" "+ i +" ");
}
}