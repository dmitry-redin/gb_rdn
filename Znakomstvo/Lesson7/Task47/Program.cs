// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
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

PrintArray(GenerateArray(3,4));
