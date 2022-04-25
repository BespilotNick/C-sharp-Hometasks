// The program that prints the third digit of a number (if it exists)

void ThirdNum(string a)
{
    if (a.Length > 2)
    {
        Console.WriteLine("The third digit of " + a + " is " + a[2]);
    }
    else
    {
        Console.WriteLine("The third digit is not exists");
    }
}

Console.WriteLine("Input you number: ");
string usernumber = Console.ReadLine();

ThirdNum(usernumber);