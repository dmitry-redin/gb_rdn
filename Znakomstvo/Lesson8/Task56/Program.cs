// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void GetMinSumRow(int[,] arr)
{
    int minSum = int.MaxValue;
    int minRowNum = -1;

    for(int row = 0; row < arr.GetLength(0); row++)
    {
        int sum = 0;

        for(int col = 0; col < arr.GetLength(1); col++)
        {
            sum += arr[row,col];
        }

        if(sum < minSum)
        {
            minSum = sum;
            minRowNum = row;
        }
    }

    if(minRowNum >= 0)
    {
        Console.WriteLine("Наименьшая сумма в строке: {0} (sum = {1})", minRowNum+1, minSum);
    }
}

var arr = GenerateArray(4,4);

PrintArray(arr);

GetMinSumRow(arr);
