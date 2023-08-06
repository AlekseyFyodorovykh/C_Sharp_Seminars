/* Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N. */
Console.WriteLine("Введите целое число");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = 2;

while (number_2 < number_1)
{
Console.WriteLine(number_2);
number_2 = number_2 + 2;
}