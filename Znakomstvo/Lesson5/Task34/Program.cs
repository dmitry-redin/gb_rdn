//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] GenerateArray(int len)
{
    var arr = new int[len];

    var rand = new Random();

    for(int i = 0; i < len; i++)
    {
        arr[i] = rand.Next(100, 1000);
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

int FindMod2(int[] arr)
{
    int k = 0;
    foreach(var num in arr)
    {
        if(num%2 == 0)
        {
            k++;
        }
    }

    return k;
}

int len = int.Parse(Console.ReadLine());

var arr = GenerateArray(len);

PrintArray(arr);

Console.WriteLine(FindMod2(arr));


