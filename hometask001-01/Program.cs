Console.Write("Input first integer number:  ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number:  ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
    Console.WriteLine("Max number is " + number1);
else
    Console.WriteLine("Max number is " + number2);