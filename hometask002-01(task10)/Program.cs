// The programm that shows the second digit of three-digit number

void SecDig(int a)
{
    int a2 = a % 100;
    int a1 = a2 / 10;

    Console.WriteLine("The second digit in your numer is " + a1);
}

Console.WriteLine("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
SecDig(num);