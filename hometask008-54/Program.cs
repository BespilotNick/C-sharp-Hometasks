/* Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8
*/

Console.WriteLine("Input number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min size for range: ");
int sizemin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max size for range: ");
int sizemax = Convert.ToInt32(Console.ReadLine());

int[,] Array = new int[row, col];

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        Array[i, j] = new Random().Next(sizemin, sizemax + 1);
        Console.Write(Array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

void OderedArray(int[,] array)
{
    for (int i = 0; i < row; i++)                // row = array.GetLength(0)
    {
        for (int j = 0; j < col; j++)            // col = array.GetLength(1)
        {
            for (int k = j+1; k < col; k++)        // col = array.GetLength(1)
            {
                if (array[i, k] < array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();  
    }
}

OderedArray(Array);