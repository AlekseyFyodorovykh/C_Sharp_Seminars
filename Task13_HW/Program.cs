/* Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int ShowTherdDigit(int Digit)
{
 int TherdDigit = (Digit % 1000) / 100;
 return TherdDigit;
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = ShowTherdDigit(number);
if (number > 99)
{
 Console.WriteLine($"Третья последняя цифра: {result}");
}
else
{
 Console.WriteLine("Третьей цифры нет");
}


