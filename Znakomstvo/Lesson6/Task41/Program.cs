// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int GetInt()
{
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray(int len)
{
    var arr = new int[len];

    int i = 0;

    while(i < len)
    {
        arr[i] = GetInt();
        i++;
    }

    return arr;
}

void PrintArray(int[] arr)
{
    foreach(var a in arr)
    {
        Console.Write(a.ToString() + " ");
    }

    Console.WriteLine();
}

int FindPositive(int[] arr)
{
    int pos = 0;

    foreach(var a in arr)
    {
        if(a > 0) pos++;
    }

    return pos;
}

int len = GetInt();

var arr = GetArray(len);

PrintArray(arr);

Console.WriteLine(FindPositive(arr));


