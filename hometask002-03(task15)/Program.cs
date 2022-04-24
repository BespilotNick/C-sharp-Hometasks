// The programm which takes as input a digit indicating the day of the week and checks if this day is a weekend.

void IsAWeekend(int a)
{
    if (a > 7)
    {
        Console.WriteLine("Invalid number! Please, input the coorect number (in range from 1 to 7)");
    }
    else if (a == 6 || a == 7)
    {
        Console.WriteLine("This day IS a weekend :)");
    }
    else if (a == 5)
    {
        Console.WriteLine("This day is not a weekend, THIS IS FRIDAY!!!");
    }
    else
    {
        Console.WriteLine("This day IS NOT a weekend ;)");
    }
}

Console.WriteLine("Input the number of the day: ");
int numOfDay = Convert.ToInt32(Console.ReadLine());

IsAWeekend(numOfDay);