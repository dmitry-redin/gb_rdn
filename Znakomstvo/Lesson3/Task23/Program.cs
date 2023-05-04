// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int N = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= N; i++)
{
    if( i != N)
    {
        Console.Write((i*i*i).ToString() + ", ");
    }
    else
    {
         Console.WriteLine(i*i*i);
    }
}
