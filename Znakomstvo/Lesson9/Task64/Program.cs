// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void PrintNumber(int number)
{
    if(number == 1)
    {
        Console.WriteLine("{0}", number);
        return;
    }

    Console.Write("{0}, ", number);
    PrintNumber(number-1);
}

int N = Convert.ToInt32(Console.ReadLine());

PrintNumber(N);
