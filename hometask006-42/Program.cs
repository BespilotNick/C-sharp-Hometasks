// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101     3 -> 11     2 -> 10

void ConverterFrom_10_To_2(int a)
{
    double res = 0;
    double count = 0;

    while (a > 0)
    {
        res += (a % 2) * Math.Pow(10, count);
        a = a / 2;
        count += 1;
    }
    Console.WriteLine("Your number in binary system is: " + res);
}

Console.WriteLine("Input number:  ");
int usernum = Convert.ToInt32(Console.ReadLine());
ConverterFrom_10_To_2(usernum);