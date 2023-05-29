// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] GenerateArray(int len)
{
    var rand = new Random();

    var arr = new double[len];

    int i = 0;

    while(len > 0)
    {
        arr[i] = rand.NextDouble()*100f;
        len--;
        i++;
    }

    return arr;
}

void PrintArray(double[] arr)
{
    foreach(var num in arr)
    {
        Console.Write(num.ToString() + " ");
    }

    Console.WriteLine();
}

double FindMin(double[] arr)
{
    var min = double.MaxValue;

    foreach(var n in arr)
    {
        if(n < min)
        {
            min = n;
        }
    }

    return min;
}

double FindMax(double[] arr)
{
    var max = double.MinValue;

    foreach(var n in arr)
    {
        if(n > max)
        {
            max = n;
        }
    }

    return max;
}

int len = int.Parse(Console.ReadLine());

var arr = GenerateArray(len);

PrintArray(arr);

Console.WriteLine(FindMax(arr) - FindMin(arr));
