/*
Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

if(number > 0)
    {
        while(current <= number)
        {
            if((current % 2) == 0)
                Console.Write(current + "  ");
                current++;
        }
    }

if(number < 0)
    {
        while(current >= number)
            {
                if((current % 2) == 0)
                    Console.Write(current + "  ");
                    current--;
            }
    }