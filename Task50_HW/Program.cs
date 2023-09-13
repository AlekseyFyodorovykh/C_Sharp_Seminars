/*50 Напишите программу, которая на вход принимает позицию элемента
в двумерном массиве и возвращает значение этого массива или же указание,
что такого элемента массива нет
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


bool CheckMatrix(int[,] matrix, int findRow, int findColumn)
{
 return (findRow <= matrix.GetLength(0)) && (findColumn <= matrix.GetLength(1));
}

int FindElem(int[,] matrix, int findRow, int findColumn)
{
 return matrix[findRow, findColumn];
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

int[,] array2d = CreateMatrixRndInt(5, 5, -100, 100);
PrintMatrix(array2d);

Console.Write("Введите номер строки элемента: ");
int numberRow = (Convert.ToInt32(Console.ReadLine())-1);
Console.Write($"{numberRow}");

Console.Write("Введите номер столбца элемента: ");
int numberColumn = (Convert.ToInt32(Console.ReadLine())-1);

if (!CheckMatrix(array2d, numberRow, numberColumn))
{
 Console.WriteLine("Такого элемента массива нет");
 return;
}

int findElem = FindElem(array2d, numberRow, numberColumn);
Console.Write($"{findElem}");
