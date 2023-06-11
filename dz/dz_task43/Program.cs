// Задача 43. 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем
// b1 = 2, k1 = 5, b2 = 4,
// k2 = 9 -> (-0,5; -0,5)

//Point of Intersection (x, y) = ((b1×c2 − b2×c1)/(a1×b2 − a2×b1), (c1×a2 − c2×a1)/(a1×b2 − a2×b1))
// 0=k1*x-y+b1 , k2*x-y+b2 ; k1=a1, -1=b1, c1=b1

Console.Clear();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

int c1=Prompt("Введите значение коэфициента b1 в формуле 'y = k1 * x + b1' : ");
int a1=Prompt("Введите значение коэфициента k1 в формуле 'y = k1 * x + b1' : ");
double b1=-1;
int c2=Prompt("Введите значение коэфициента b2 в формуле 'y = k1 * x + b1' : ");
int a2=Prompt("Введите значение коэфициента k2 в формуле 'y = k1 * x + b1' : ");
double b2=-1;

double crossDotX = (((b1*c2)-(b2*c1)) / ((a1*b2)-(a2*b1)));
double crossDotY = (((c1*a2)-(c2*a1)) / ((a1*b2)-(a2*b1)));

// int a=((b1*c2)-(b2*c1)); debug output
// int b=((a1*b2)-(a2*b1));
// int c=((c1*a2)-(c2*a1));
// int d=((a1*b2)-(a2*b1));
// int e=a/b;
// int f=c/d;
// Console.WriteLine($"{a} {b} {c} {d} {e} {f}");

Console.WriteLine ($"Точка пересечения заданных прямых (x,y): ( {crossDotX} , {crossDotX} )");