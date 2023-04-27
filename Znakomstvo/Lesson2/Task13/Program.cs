// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int numberCount(int num)
{
    int c = 1;

    while(num > 0)
    {
        num /= 10;
        if(num !=0)
        {
            c++;
        }
    }

    return c;
}

int n = Convert.ToInt32(Console.ReadLine());

int f = numberCount(n);

if(f >= 3)
{
    Console.WriteLine((n/((int)Math.Pow(10,(f-3))))%10);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
