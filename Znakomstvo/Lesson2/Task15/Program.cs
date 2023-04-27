// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool isWeekend(int day)
{
    return day == 6 || day == 7;
}

int d = Convert.ToInt32(Console.ReadLine());

if(isWeekend(d))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
