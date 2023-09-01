/* Напишите программу, которая принимает на вход число
и выдает сумму цифр в числе */

int SummOfDigitCount(int num)
{
 int DigitCount = 0;
 while (num != 0)
 {
  DigitCount = DigitCount + num % 10;
  num = num / 10;
 }
 return DigitCount;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {number} = {SummOfDigitCount(number)}");
