//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// a*x + c = b*x + d
using static System.Convert;
using static System.Console;

double GetDouble()
{
    return ToDouble(ReadLine());
}

double[] Intersection(double a, double c, double b, double d)
{
    return new double[2]{(d-c)/(a-b),a*((d-c)/(a-b)) + c};
}

void PrintPoint(double[] point)
{
    WriteLine("{0:F2}, {1:F2}", point[0], point[1]);
}

var a = GetDouble();
var c = GetDouble();
var b = GetDouble();
var d = GetDouble();

PrintPoint(Intersection(a,c,b,d));
