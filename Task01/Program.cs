// Напишите команду, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго
Console.WriteLine("Введите число А");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int number_2 = Convert.ToInt32(Console.ReadLine());
if (number_2 * number_2 == number_1)
{
     Console.WriteLine($"Число {number_1} - это квадрат числа {number_2}");
}
else
{
Console.WriteLine($"Число {number_1} - не квадрат числа {number_2}");
}


