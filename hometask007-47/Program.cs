// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/* m = 3, n = 4.    
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9    
*/

Console.WriteLine("Input number of rows:  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns:  ");
int col = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[row, col];

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        matrix[i, j] = Math.Round(new Random().NextDouble(), 2);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}