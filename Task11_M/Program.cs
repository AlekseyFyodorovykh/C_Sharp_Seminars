// Наипишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

int DeleteSecondDigit(int num)
{
 int FirstDigit = num / 100;
 int ThirdDigit = num % 10;
 int result = FirstDigit * 10 + ThirdDigit;
 return result;
}

int number = new Random().Next(100, 1000);
int NewNumber = DeleteSecondDigit(number);

//Console.WriteLine($"{NewNumber}");

Console.WriteLine($"Дано: {number}. Ответ: {NewNumber}");