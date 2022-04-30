// list of numbers to the third power

void ListOfThirdPower(int N)
{
    int num = 1;

    while(num <= N)
    {
        int result = num*num*num;
        num++;
        Console.Write(result + " ");
    }
}

Console.WriteLine("Input a number: ");
int usernum = Convert.ToInt32(Console.ReadLine());

ListOfThirdPower(usernum);