// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int Prompt (string message) 
{
Console.Write(message);
int num = int.Parse(Console.ReadLine()!);
return num;
}

int x1 = Prompt ("Введите координату X точки A: ");
int y1 = Prompt ("Введите координату Y точки A: ");
int z1 = Prompt ("Введите координату Z точки A: ");

int x2 = Prompt ("Введите координату X точки B: ");
int y2 = Prompt ("Введите координату Y точки B: ");
int z2 = Prompt ("Введите координату Z точки B: ");

void CalcDist (int x1, int y1, int x2, int y2, int z1, int z2) 
{
double d = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
Console.WriteLine("Расстояние между точками в 3D пространстве: " + d);
}

CalcDist(x1, y1, x2, y2, z1, z2);





