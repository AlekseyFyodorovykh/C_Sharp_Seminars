/* Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max)
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

int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
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

int[,] MultMatrix(int[,] arr1, int[,] arr2)
{
 int mult = 0;
 int summ = 0;
 int[,] matrix = new int[arr1.GetLength(0), arr2.GetLength(1)];

 for (int i = 0; i < arr1.GetLength(0); i++)
 {
  for (int j = 0; j < arr2.GetLength(1); j++)
  {
   for (int k = 0; k < arr1.GetLength(0); k++)
   {
    mult = arr1[i, k] * arr2[k, j];
    summ = summ + mult;
   }
   matrix[i, j] = summ;
   summ=0;
  }
 }
 return matrix;
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

bool CheckMatrix (int[,] arr1, int[,] arr2)
{
return arr1.GetLength(0)==arr2.GetLength(1);
}

int[,] array1 = CreateMatrixRndInt1(3, 3, -10, 10);
PrintMatrix(array1);
Console.WriteLine();
int[,] array2 = CreateMatrixRndInt2(3, 3, -10, 10);
PrintMatrix(array2);
Console.WriteLine();
if (!CheckMatrix(array1, array2))
{
 Console.WriteLine("Невозможно перемножить матрицы");
 return;
}
int[,] multiArray = MultMatrix(array1, array2);
PrintMatrix(multiArray);