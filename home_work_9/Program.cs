// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.Write("Введите координаты точнки x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точнки x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точнки y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точнки y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точнки z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точнки z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double points(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double result = ((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return Math.Sqrt(result);
}
Console.Write("Расстояние между точками в 3D пространстве: ");
Console.WriteLine(points(x1,x2,y1,y2,z1,z2));

