// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Sum(int M, int N)
{
    if(M == N)
    {
        return N;
    }

    return N + Sum(M, N - 1);
}

var M = Convert.ToInt32(Console.ReadLine());
var N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(M, N));