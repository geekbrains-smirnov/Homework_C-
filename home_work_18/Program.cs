﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите целое число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

void Coordinates(double b1, double k1, double b2, double k2 )
{
    double y = 0;
    double x = 0;
    if((k1==k2) && (b1==b2)) Console.WriteLine("Прямые совпадают!");
    else if (k1==k2) Console.WriteLine("Прямые параллельны!");
    else
    {
        x = x+(b2-b1)/(k1-k2);
        y = y+(k1*(b2-b1)/(k1-k2)+b1);
        
    }
    Console.WriteLine($"Координаты точки пересечения двух прямых ({x}, {y}) ") ;
    
}

Coordinates(b1,k1,b2,k2);
