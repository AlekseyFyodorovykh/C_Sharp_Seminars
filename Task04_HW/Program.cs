// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число А");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
int number_3 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
   if (number_1 > number_3)
   Console.WriteLine($"число {number_1} максимальное");
   else
   Console.WriteLine($"число {number_3} максимальное");
else
 if (number_2 > number_3)
  Console.WriteLine($"число {number_2} максимальное");
 else
  Console.WriteLine($"число {number_3} максимальное");