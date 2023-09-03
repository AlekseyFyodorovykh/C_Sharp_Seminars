/* Задайте массив, заполненный случайными положительными трехзначными числами.
Напишите программу, которая покажет количество четных чисел в массиве. */


int[] CreateArrayRndInt(int size, int min, int max)
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

int EvenElem(int[] arr)
{
 int count = 0;
 for (int i = 0; i < arr.Length; i++)
 {
  if (arr[i] % 2 == 0) count++;
 }
 return count;
}

int[] array = CreateArrayRndInt(8, 100, 999);
PrintArray(array);
Console.WriteLine();
int elemEven = EvenElem(array);
Console.WriteLine($"Количество четных чисел в массиве {elemEven}");

