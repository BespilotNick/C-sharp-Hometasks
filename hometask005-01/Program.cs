// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// 3, 5 -> 243 (3⁵)      2, 4 -> 16

void Exponentiation(int a, int b)
{
    int result = a;
    int count = 1;

    while (count < b)
    {
        result *= a;
        count++;
    }

    Console.WriteLine("The result of raising the number " + a + " to the power of " + b + " is " + result);
}

Console.WriteLine("Input number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int B = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(A);
//Console.WriteLine(B);
Exponentiation(A, B);