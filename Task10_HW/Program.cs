// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ShowSecondDigit(int num)
{
 int FirstDigit = num / 100;
 int ThirdDigit = num % 10;
 int result = (num - (FirstDigit * 100 + ThirdDigit))/10;
 return result;
}

int number = new Random().Next(100, 1000);
int NewNumber = ShowSecondDigit(number);

//Console.WriteLine($"{NewNumber}");

Console.WriteLine($"Дано: {number}. Ответ: {NewNumber}");