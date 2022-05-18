// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.   */

int[,] matrix = new int[5, 7];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

void ArithMeanCol(int[,] matrix)
{
    Console.WriteLine("Arithmetic mean for each column is: ");
    
    double meanCol = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sumCol = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumCol += matrix[i, j];
        }
        meanCol = Math.Round(sumCol / matrix.GetLength(0), 1);
        Console.Write(meanCol + "\t");
    }   
}

ArithMeanCol(matrix);