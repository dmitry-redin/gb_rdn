// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] GenerateArray(int len)
{
    var rand = new Random();

    var arr = new int[len];

    int i = 0;

    while(len > 0)
    {
        arr[i] = rand.Next(0, 100);
        len--;
        i++;
    }

    return arr;
}

void PrintArray(int[] arr)
{
    foreach(var num in arr)
    {
        Console.Write(num.ToString() + " ");
    }

    Console.WriteLine();
}

int Sum(int[] arr)
{
    int s = 0;
    for(int i = 1; i < arr.Length; i += 2)
    {
        s += arr[i];
    }

    return s;
}

int len = int.Parse(Console.ReadLine());

var arr = GenerateArray(len);

PrintArray(arr);

Console.WriteLine(Sum(arr));
