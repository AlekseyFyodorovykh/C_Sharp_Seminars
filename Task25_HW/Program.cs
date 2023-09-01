/* Задача 25: Напишите цикл, который принимает на вход два
числа (А и В) и возводит число А в натуральную степень В */

int ADegreeB(int num1, int num2)
{
 int multiplex = 1;
 for (int i = 1; i <= num2; i++)
 {
  checked     // оператор, проверяющий переполнение типа
  {
   multiplex = multiplex * num1; //где нужно проверить переполнение
  }
  
 }
 return multiplex;
}

Console.WriteLine("Введите число А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int numB = Convert.ToInt32(Console.ReadLine());

int aDegreeb = ADegreeB(numA, numB);

if (numA < 1 || numB < 1)
{
 Console.WriteLine("Числа А, В должны быть натуральными");
 return;
}
 Console.WriteLine($"Число {numA} в степени {numB} = {aDegreeb}");

