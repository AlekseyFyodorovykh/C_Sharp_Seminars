// Наипишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int FirstDigit = number / 100;
int ThirdDigit = number % 10;

int result= FirstDigit*10+ThirdDigit;

Console.WriteLine($"Дано: {number}. Ответ: {result}");
