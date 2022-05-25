/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("Input number of row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] Matrix = new int[row, col];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        Matrix[i, j] = new Random().Next(0, 15);
        Console.Write(Matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

int SmallestSumInRow(int[,] matrix)
{
    int minsum = 0;
    int minrow = 1;
    for (int k = 0; k < col; k++)
        minsum += matrix[0, k];
    Console.WriteLine("Sum of elements in " + minrow + " row is: " + minsum);

    for (int i = 1; i < row; i++)
    {
        int sumrow = 0;
        int row = i + 1;
        for (int j = 0; j < col; j++)
        {
            sumrow += matrix[i, j];
        }
        Console.WriteLine("Sum of elements in " + row + " row is: " + sumrow);

        if (sumrow < minsum)
        {
            minsum = sumrow;
            minrow = row;
        }
    }
    return minrow;
}

Console.WriteLine("The smallest sum of elements in row № " + SmallestSumInRow(Matrix));