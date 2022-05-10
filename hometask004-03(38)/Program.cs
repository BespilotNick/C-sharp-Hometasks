// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void DifferenceOfNumbers(int[] array)
{
    int minElt = array[0];
    int maxElt = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElt)
            maxElt = array[i];
        else if (array[i] < minElt)
            minElt = array[i];
    }
    Console.WriteLine("Maximal element is: " + maxElt);
    Console.WriteLine("Minimal element is: " + minElt);
    
    int difOfNum = maxElt - minElt;
    Console.WriteLine("Difference Of Numbers in array is: " + difOfNum);
}

int[] myArray = CreateArray(12, -50, 789);
PrintArray(myArray);
DifferenceOfNumbers(myArray);