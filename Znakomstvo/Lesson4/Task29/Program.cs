// See https://aka.ms/new-console-template for more information
int[] GenerateArray(int len)
{
    var arr = new int[len];
    Random rand = new Random();
    for(int i = 0; i < len; i++)
    {
        arr[i] = rand.Next(0,10);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i].ToString() + " ");
    }
    Console.WriteLine();
}

int len = Convert.ToInt32(Console.ReadLine());

var arr = GenerateArray(len);

PrintArray(arr);
