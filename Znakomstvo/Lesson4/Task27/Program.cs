// See https://aka.ms/new-console-template for more information
int SumNums(int n)
{
    int sum = n%10;
    n /= 10;

    while(n > 0)
    {
        sum += n%10;
        n /= 10;
    }

    return sum;
}

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNums(n));
