﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) ???

// x = (b2 - b1) / (k1 - k2)

void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine("Intersection Point is: (" + x + ", " + y + ")");
}

Console.WriteLine("Input k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2");
double b2 = Convert.ToInt32(Console.ReadLine());
IntersectionPoint(k1, b1, k2, b2);