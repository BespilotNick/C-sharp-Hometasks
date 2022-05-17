// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2    1, -7, 567, 89, 223-> 3


int[] GettingNums(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Input " + (i + 1) + " number: ");
        int unum = Convert.ToInt32(Console.ReadLine());
        newArray[i] = unum;
    }
    Console.WriteLine();
    
    for (int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " ");
    Console.WriteLine();
    
    return newArray;
}

void HowManyPositive(int[] array)
{
    int posNum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            posNum += 1;
    }
    
    if (posNum == 0)
        Console.WriteLine("There is no any number more than 0 among gotten once");
    else if (posNum == 1)
        Console.WriteLine("There is only 1 number more than 0 among gotten once");
    else
        Console.WriteLine("There are " + posNum + " numbers more than 0 among gotten once");
}

Console.WriteLine("How many numbers would you like to check?  ");
int size = Convert.ToInt32(Console.ReadLine());
HowManyPositive(GettingNums(size));