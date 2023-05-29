// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int PowI(int x, int n)
{
    int res = 1;
    for(int i = 1; i <=n ;i++)
    {
        res *= x;
    }

    return res;
}

int x = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PowI(x, n));