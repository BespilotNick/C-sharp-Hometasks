// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11    82 -> 10       9012 -> 12

void SumOfDigits(int a)
{
    int res = 0;

    if (a < 0)
        a *= (-1);      // Не знаю насколько это целесообразно, но пусть будет, наверное

    while (a > 0)
    {
        res += a % 10;
        a = a / 10;
    }
    Console.WriteLine("Sum of digits in your nuber is " + res);
}

Console.WriteLine("Input your number: ");
int usernum = Convert.ToInt32(Console.ReadLine());
SumOfDigits(usernum);