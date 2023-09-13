/* 
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка 
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

int[] SummOfRowsMatrix(int[,] matrix)
{
 int[] array = new int[matrix.GetLength(0)];
 for (int i = 0; i < array.Length; i++)
 {
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
   array[i] = array[i] + matrix[i, j];
  }
 }
 return array;
}

int ResultCompareOfRowsMatrix(int[] matrix)
{
 int minRow = matrix[0];
 int result=0;
 for (int i = 1; i < matrix.Length; i++)
 {
  if (matrix[i] < minRow)
  {
  minRow = matrix[i];
  result=i;
  }
 }
 return result+1;
}

void PrintArray(int[] arr)
{
 Console.Write("[");
 for (int i = 0; i < arr.Length; i++)
 {
  if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
  else Console.Write($"{arr[i]}");
 }
 Console.Write("]");
}

int[,] array2d = CreateMatrixRndInt(4, 4, -100, 100);
PrintMatrix(array2d);

int[] summOfRowsMatrix = SummOfRowsMatrix(array2d);
PrintArray(summOfRowsMatrix);
Console.WriteLine();
int resultCompareOfRowsMatrix = ResultCompareOfRowsMatrix(summOfRowsMatrix);
Console.WriteLine($"Минимальная сумма элементов в строке № {resultCompareOfRowsMatrix}");
