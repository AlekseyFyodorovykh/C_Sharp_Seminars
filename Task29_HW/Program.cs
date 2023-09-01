/* Задача 29: напишите программу, которая
задает массив из 8 элементов, заполненный
псевдослучайными числами и выводит их на экран */


void FillArray(int[] collection)
{
 int length = collection.Length;
 int index = 0;
 while (index < length)
 {
  collection[index] = new Random().Next();
  index++;
 }
}

void PrintArray(int[] col)
{
 int count = col.Length;
 int position = 0;
 while (position < count)
 {
  //Console.WriteLine(col[position]); //вывод в столбец
  Console.Write(col[position] + " "); // вывод в строку
  position++;
 }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);


