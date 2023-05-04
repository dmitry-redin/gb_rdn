//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int value = Convert.ToInt32(Console.ReadLine());
var numbers = new List<int>();

int v = value;

do
{
    numbers.Add((v % 10));
    v /= 10;
} while(v > 0);

// foreach(var e in numbers)
// {
//     Console.WriteLine(e);
// }

bool isPalindrome = true;

for(int i = 0; i < numbers.Count()/2; i++)
{
    if(numbers[i] != numbers[numbers.Count()-i-1])
    {
        isPalindrome = false;
        break;
    }
}

if(isPalindrome)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
