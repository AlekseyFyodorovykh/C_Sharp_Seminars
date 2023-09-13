/* Задайте двумерный массив размером m*n,
заполненный случайными вещественными числами. */

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
 double[,] matrix = new double[rows, columns];
 Random rnd = new Random();
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
   matrix[i, j] = rnd.NextDouble() * (max - min) + min;
  }
 }
 return matrix;
}

double[,] RoundArrayRndDouble(double[,] arr)
{

 for (int i = 0; i < arr.GetLength(0); i++)
 {
  for (int j = 0; j < arr.GetLength(1); j++)
  {
   arr[i, j] = Math.Round(arr[i, j], 2);
  }
 }
 return arr;
}

void PrintMatrix(double[,] matrix)
{

 for (int i = 0; i < matrix.GetLength(0); i++)
 {
  Console.Write("|");
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
   Console.Write($"{matrix[i, j],6}");
  }
  Console.WriteLine("   |");
 }
}

double[,] array2d = CreateMatrixRndDouble(3, 4, -100, 100);
double[,] roundArray2d = RoundArrayRndDouble(array2d);
PrintMatrix(roundArray2d);
