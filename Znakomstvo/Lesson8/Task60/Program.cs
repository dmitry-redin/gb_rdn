// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GenerateArray(int m, int n, int k)
{
    var arr = new int[m,n,k];

    var numbers = new HashSet<int>();

    var rand = new Random();

    for(int row = 0; row < m; row++)
    {
        for(int col = 0; col < n; col++)
        {
            for(int dep = 0; dep < k; dep++)
            {
                var number = rand.Next(0,100);

                while(numbers.Contains(number))
                {
                    number = rand.Next(0,100);
                }

                numbers.Add(number);

                arr[row, col, dep] = number;
            }
        }
    }

    return arr;
}

void PrintArray(int[,,] arr)
{
    for(int row = 0; row < arr.GetLength(0); row++)
    {
        for(int col = 0; col < arr.GetLength(1); col++)
        {
            for(int dep = 0; dep < arr.GetLength(2); dep++)
            {
                Console.Write("{0}({1},{2},{3}) ", arr[row,col,dep], row, col, dep);
            }
            Console.WriteLine();
        }
    }
}

var arr = GenerateArray(2,2,2);

PrintArray(arr);
