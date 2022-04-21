Console.Write("Input first integer number:  ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number:  ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number:  ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max;

if(number1 > number2)
    max = number1;
else
    max = number2;

if(max > number3)
    Console.WriteLine("Max number is " + max);
else
    Console.WriteLine("Max number is " + number3);