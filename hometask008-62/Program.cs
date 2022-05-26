﻿/* Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:
1   2   3   4
12  13  14  5
11  16  15  6
10  9   8   7
*/

/* Самый простой способ - заполнить массив вручную для каждого элемента,

int[,] SpiralMatrix = new int[4, 4];

SpiralMatrix[0, 0] = 1;
SpiralMatrix[0, 1] = 2;
SpiralMatrix[0, 2] = 3;
SpiralMatrix[0, 3] = 4;
SpiralMatrix[1, 0] = 12;
SpiralMatrix[1, 1] = 13;
SpiralMatrix[1, 2] = 14;
SpiralMatrix[1, 3] = 5;
SpiralMatrix[2, 0] = 11;
SpiralMatrix[2, 1] = 16;
SpiralMatrix[2, 2] = 15;
SpiralMatrix[2, 3] = 6;
SpiralMatrix[3, 0] = 10;
SpiralMatrix[3, 1] = 9;
SpiralMatrix[3, 2] = 8;
SpiralMatrix[3, 3] = 7;

Console.Write(SpiralMatrix[0, 0] + "\t" + SpiralMatrix[0, 1] + "\t" + SpiralMatrix[0, 2] + "\t" + SpiralMatrix[0, 3]);
Console.WriteLine();
Console.Write(SpiralMatrix[1, 0] + "\t" + SpiralMatrix[1, 1] + "\t" + SpiralMatrix[1, 2] + "\t" + SpiralMatrix[1, 3]);
Console.WriteLine();
Console.Write(SpiralMatrix[2, 0] + "\t" + SpiralMatrix[2, 1] + "\t" + SpiralMatrix[2, 2] + "\t" + SpiralMatrix[2, 3]);
Console.WriteLine();
Console.Write(SpiralMatrix[3, 0] + "\t" + SpiralMatrix[3, 1] + "\t" + SpiralMatrix[3, 2] + "\t" + SpiralMatrix[3, 3]);

но это не по-программистски :-)
по этому, что-нибудь придумаем */

/*
int[,] SpiralMatrix = new int[4, 4];

for (int j = 0; j < SpiralMatrix.GetLength(1); j++)
    SpiralMatrix[0, j] = j + 1;

for (int i = 1, k = (SpiralMatrix[0, (SpiralMatrix.GetLength(1) - 1)]) + 1; i < SpiralMatrix.GetLength(0); i++, k++)
    SpiralMatrix[i, ((SpiralMatrix.GetLength(1) - 1))] = k;

for (int j = (SpiralMatrix.GetLength(1) - 2), k = (SpiralMatrix[(SpiralMatrix.GetLength(0) - 1), (SpiralMatrix.GetLength(1) - 1)] + 1); 
k < (SpiralMatrix[(SpiralMatrix.GetLength(0) - 1), (SpiralMatrix.GetLength(1) - 1)] + SpiralMatrix.GetLength(1)); j--, k++)
    SpiralMatrix[(SpiralMatrix.GetLength(0) - 1), j] = k;

for (int i = SpiralMatrix.GetLength(0) - 2, k = (SpiralMatrix[(SpiralMatrix.GetLength(0) - 1), 0] + 1); 
i > 0 && k <= (SpiralMatrix[(SpiralMatrix.GetLength(0) - 1), 0] + ((SpiralMatrix.GetLength(0) - 1) - 1)); i--, k++)
    SpiralMatrix[i, 0] = k;

// Где-то тут потерялась логика, если кто найдет, верните, пожалуйста

for (int j = (SpiralMatrix.GetLength(1) - 3), k = (SpiralMatrix[1, 0] + 1); 
j < (SpiralMatrix.GetLength(1) - 1) && k <= (SpiralMatrix[(SpiralMatrix.GetLength(0) - 3), 0] + SpiralMatrix.GetLength(1) - 2); j++, k++)
    SpiralMatrix[1, j] = k;

for (int j = (SpiralMatrix.GetLength(1) - 2), k = (SpiralMatrix[1, 2] + 1); 
j > (SpiralMatrix.GetLength(1) - 4) && k < (SpiralMatrix[(SpiralMatrix.GetLength(0) - 3), 2] + SpiralMatrix.GetLength(1) - 1); j--, k++)
    SpiralMatrix[2, j] = k;

for (int i = 0; i < SpiralMatrix.GetLength(0); i++)
{
    for (int j = 0; j < SpiralMatrix.GetLength(1); j++)
    {
        Console.Write(SpiralMatrix[i, j] + "\t");
    }
    Console.WriteLine();
}
*/


// Пщпробуем немного оптимизировать:

int size = 4;

int[,] SpiralMatrix = new int[size, size];

for (int j = 0; j < size; j++)
    SpiralMatrix[0, j] = j + 1;

for (int i = 1, k = (SpiralMatrix[0, (size - 1)]) + 1; i < size; i++, k++)
        SpiralMatrix[i, ((size - 1))] = k;

for (int j = (size - 2), k = (SpiralMatrix[(size - 1), (size - 1)] + 1); j >= 0; j--, k++)
    SpiralMatrix[(size - 1), j] = k;

for (int i = size - 2, k = (SpiralMatrix[(size - 1), 0] + 1); i > 0; i--, k++)
    SpiralMatrix[i, 0] = k;

for (int j = 1, k = (SpiralMatrix[1, 0] + 1); j < (size - 1); j++, k++)
    SpiralMatrix[1, j] = k;

for (int j = (size - 2), k = (SpiralMatrix[1, 2] + 1); j > 0; j--, k++)
    SpiralMatrix[2, j] = k;

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write(SpiralMatrix[i, j] + "\t");
    }
    Console.WriteLine();
}

// Так, вроде бы, больше похоже на язык программистов, но все равно чушь несусветная