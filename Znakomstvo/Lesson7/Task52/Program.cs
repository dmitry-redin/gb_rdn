// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] GenerateArray(int m, int n)
{
    var arr = new int[m,n];

    var rand = new Random();

    for(int row = 0; row < m; row++)
    {
        for(int col = 0; col < n; col++)
        {
            arr[row, col] = rand.Next(0,10);
        }
    }

    return arr;
}

int[,] PrintArray(int[,] arr)
{
    for(int row = 0; row < arr.GetLength(0); row++)
    {
        for(int col = 0; col < arr.GetLength(1); col++)
        {
            Console.Write("{0} ", arr[row, col]);
        }
        Console.WriteLine();
    }

    return arr;
}

void FindMid(int[,] arr)
{
    for(int col = 0; col < arr.GetLength(1); col++)
    {
        double sum = 0;

        for(int row = 0; row < arr.GetLength(0); row++)
        {
            sum += arr[row, col];
        }

        Console.Write("{0:F1} ", sum/arr.GetLength(0));
    }

    Console.WriteLine();
}

FindMid(PrintArray(GenerateArray(3,4)));

