/* Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
 */

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
 int[,] matrix = new int[rows, columns];
 Random rnd = new Random();
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
   matrix[i, j] = rnd.Next(min, max + 1);
  }
 }
 return matrix;
}

double[] AvarageOfMatrixColumns(int[,] matrix)
{
 int rows = matrix.GetLength(0);
 int columns = matrix.GetLength(1);
 double[] arr = new double[columns];
 double average = 0;
 for (int j = 0; j < columns; j++)
 {
  for (int i = 0; i < rows; i++)
  {
   average = average + matrix[i, j];
  }
  arr[j] = average / rows;
  average = 0;
 }
 return arr;
}

void PrintMatrix(int[,] matrix)
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

void PrintArray(double[] arr)
{
 Console.Write("[");
 for (int i = 0; i < arr.Length; i++)
 {
  if (i < arr.Length - 1) Console.Write($"{arr[i]}   ");
  else Console.Write($"{arr[i]}");
 }
 Console.Write("]");
}

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(array2d);

double[] avarageOfMatrixColumns = AvarageOfMatrixColumns(array2d);
Console.Write("Среднее арифметическое элементов в каждом столбце ");
PrintArray(avarageOfMatrixColumns);

