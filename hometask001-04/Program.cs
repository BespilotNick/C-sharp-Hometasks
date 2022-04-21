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