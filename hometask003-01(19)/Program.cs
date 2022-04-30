//

void IsPalindrome(int N)
{
    int firstDig = N / 10000;
    int secondDig = (N / 1000) % 10;
    int fourthDig = (N % 100) / 10;
    int fifthDig = N % 10;

    if(firstDig == fifthDig && secondDig == fourthDig)
        Console.WriteLine("YES! This Is a Palindrome!");
    else
        Console.WriteLine("No, this is Not a palindrome");
}

Console.WriteLine("Input 5-digit number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

IsPalindrome(userNum);

// Не могу додуматься как провести проверку на корректность вводимого числа, учитывая, что палиндромом может быть 00000 (пять нулей).
// Проверка через String.Length работает как-то странно.