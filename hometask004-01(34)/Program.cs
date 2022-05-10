// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Например [345, 897, 568, 234] -> 2

int[] Array(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void QuantityOfEvenElements(int[] array)
{
    int even = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            even += 1;
    }
    
    Console.WriteLine("Quantity of even elements in array is: " + even);
}

int[] myArray = Array(10);
PrintArray(myArray);
QuantityOfEvenElements(myArray);