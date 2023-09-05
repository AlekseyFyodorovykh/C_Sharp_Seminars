/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

/* int CountElemMoreZero(new int[digitM])
{
 int[] arr = new int[];
 int count = 0;
 for (int i = 0; i < arr.Length; i++)
 {
  if (arr[i] > 0) count++;
 }
 return count;
} */

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

Console.Write("Введите количество чисел М, М=");
int digitM = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[digitM];
for (int i = 0; i < digitM; i++)
{
 Console.Write("Введите число ");
 int digitI = Convert.ToInt32(Console.ReadLine());
 arr[i] = digitI;
}
PrintArray(arr);
Console.WriteLine();

int count = 0;
for (int i = 0; i < digitM; i++)
{
 if (arr[i] > 0) count++;
}
Console.Write($"Количество элементов больше ноля = {count}");
