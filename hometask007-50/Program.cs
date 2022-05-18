// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет    */

int[,] CreateMatrix()
{
    int[,] matrix = new int[10, 10];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 50);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return matrix;
}

void FindElement(int[,] matrix, int x, int y)
{
    if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
        Console.WriteLine("Your element is: " + matrix[x, y]);
    else
        Console.WriteLine("There is no elements with coordinate " + x + ", " + y);
}

Console.WriteLine("Input index X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input index Y: ");
int y = Convert.ToInt32(Console.ReadLine());

FindElement(CreateMatrix(), x, y);