// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
using static System.Console;
using static System.Convert;

double[,] GenerateArray(int m, int n)
{
    var arr = new double[m,n];

    var rand = new Random();

    for(int row = 0; row < m; row++)
    {
        for(int col = 0; col < n; col++)
        {
            arr[row, col] = rand.NextDouble()*20f - 10f;
        }
    }

    return arr;
}

void PrintArray(double[,] arr)
{
    for(int row = 0; row < arr.GetLength(0); row++)
    {
        for(int col = 0; col < arr.GetLength(1); col++)
        {
            Console.Write("{0:F1} ", arr[row, col]);
        }
        Console.WriteLine();
    }
}

int GetInt()
{
    return ToInt32(ReadLine());
}

string FindElement(double[,] arr, int row, int col)
{
    try
    {
        return string.Format("{0:F1}",arr[row, col]);
    }
    catch
    {
        return "Нет такого элемента";
    }
}

var arr = GenerateArray(3,4);

PrintArray(arr);

var row = GetInt();
var col = GetInt();

WriteLine(FindElement(arr, row, col));