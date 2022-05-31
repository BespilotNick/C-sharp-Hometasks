// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumOfDigits(int a)
{
    if (a > 0)
    {
        return a % 10 + SumOfDigits(a / 10);
    }
    else
        return 0;
}

Console.WriteLine(SumOfDigits(458520));