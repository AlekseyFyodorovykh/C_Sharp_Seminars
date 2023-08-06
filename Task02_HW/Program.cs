// Напишите программу, которая на вход принимает два числа и
// выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число А");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int number_2 = Convert.ToInt32(Console.ReadLine());
if (number_1 > number_2)
{
     Console.WriteLine($"Число {number_1} - больше числа {number_2}");
}
else
 if (number_1 == number_2)
 {
      Console.WriteLine("Вы ввели одинаковые числа");
 }
 else
 {
      Console.WriteLine($"Число {number_2} - больше числа {number_1}");
 }

