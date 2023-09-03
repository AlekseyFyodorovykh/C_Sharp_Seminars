/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным
элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

// Реализация с int

/* int[] CreateArrayRndInt(int size, int min, int max)
{
 int[] arr = new int[size];
 Random rnd = new Random();

 for (int i = 0; i < arr.Length; i++)
 {
  arr[i] = rnd.Next(min, max + 1);
 }
 return arr;
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

int MaxElemOfArray(int[] arr)
{
 int MaxElem = arr[0];
 for (int i = 1; i < arr.Length; i++)
 {
  if (MaxElem < arr[i])
   MaxElem = arr[i];
 }
 return MaxElem;
}

int MinElemOfArray(int[] arr)
{
 int MinElem = arr[0];
 for (int i = 1; i < arr.Length; i++)
 {
  if (arr[i] < MinElem)
   MinElem = arr[i];
 }
 return MinElem;
}

int DifferenceOfMaxAndMin(int max, int min)
{
 int result = max - min;
 return result;
}

int[] array = CreateArrayRndInt(8, 100, 999);
PrintArray(array);

int maxElemOfArray = MaxElemOfArray(array);
Console.WriteLine();
Console.WriteLine($"{maxElemOfArray}");

int minElemOfArray = MinElemOfArray(array);
Console.WriteLine($"{minElemOfArray}");

int differenceOfMaxAndMin=DifferenceOfMaxAndMin(maxElemOfArray, minElemOfArray);
Console.WriteLine($"{differenceOfMaxAndMin}"); */

// Реализация с double


double[] CreateArrayRndDouble(int size)
{
 double[] arr = new double[size];
 Random rnd = new Random();

 for (int i = 0; i < arr.Length; i++)
 {
  arr[i] = Math.Round(rnd.NextDouble(), 2);
 }
 return arr;
}

void PrintArray(double[] arr)
{
 Console.Write("[");
 for (int i = 0; i < arr.Length; i++)
 {
  if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
  else Console.Write($"{arr[i]}");
 }
 Console.Write("]");
}

double MaxElemOfArray(double[] arr)
{
 double MaxElem = arr[0];
 for (int i = 1; i < arr.Length; i++)
 {
  if (MaxElem < arr[i])
   MaxElem = arr[i];
 }
 return MaxElem;
}

double MinElemOfArray(double[] arr)
{
 double MinElem = arr[0];
 for (int i = 1; i < arr.Length; i++)
 {
  if (arr[i] < MinElem)
   MinElem = arr[i];
 }
 return MinElem;
}

double DifferenceOfMaxAndMin(double max, double min)
{
 double result = max - min;
 return result;
}
double[] array = CreateArrayRndDouble(4);
PrintArray(array);

double maxElemOfArray = MaxElemOfArray(array);
Console.WriteLine();
Console.WriteLine($"Максимальный элемент массива: {maxElemOfArray}");

double minElemOfArray = MinElemOfArray(array);
Console.WriteLine($"Минимальный элемент массива: {minElemOfArray}");

double differenceOfMaxAndMin=DifferenceOfMaxAndMin(maxElemOfArray, minElemOfArray);
Console.WriteLine($"Разница между максимальными и минимальным элементами массива: {differenceOfMaxAndMin}"); 