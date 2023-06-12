// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] GenerateArray(int m, int n)
{
    var arr = new int[m,n];

    var rand = new Random();

    for(int row = 0; row < m; row++)
    {
        for(int col = 0; col < n; col++)
        {
            arr[row, col] = rand.Next(1,10);
        }
    }

    return arr;
}

void PrintArray(int[,] arr)
{
    for(int row = 0; row < arr.GetLength(0); row++)
    {
        for(int col = 0; col < arr.GetLength(1); col++)
        {
            Console.Write("{0} ", arr[row, col]);
        }
        Console.WriteLine();
    }
}

void SortRows(ref int[,] arr)
{
    for(int row = 0; row < arr.GetLength(0); row++)
    {
        var rowEls = new int[arr.GetLength(1)];

        for(int col = 0; col < arr.GetLength(1); col++)
        {
            rowEls[col] = arr[row, col];
        }

        Array.Sort(rowEls);

        for(int col = arr.GetLength(1) - 1; col >= 0; col--)
        {
            arr[row, arr.GetLength(1) - col - 1] = rowEls[col];
        }
    }
}

var arr = GenerateArray(3, 4);

PrintArray(arr);

SortRows(ref arr);

Console.WriteLine("\nSorted:");

PrintArray(arr);


