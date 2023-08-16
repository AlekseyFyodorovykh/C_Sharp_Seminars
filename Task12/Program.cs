// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли первое число кратны второму. Ксли первое
//не кратно второму - выводить остаток от деления

int Remainder(int first, int second)
{
 return first % second;
}

Console.WriteLine("Введите два числа");
int FirstDigit = Convert.ToInt32(Console.ReadLine());
int SecondDigit = Convert.ToInt32(Console.ReadLine());
// Вариант через if:
int remainder = Remainder(FirstDigit, SecondDigit);
if (remainder == 0)
 Console.WriteLine($"Кратно, {remainder}");
else
 Console.WriteLine($"Не кратно, остаток {remainder}");

// Вариант через тернарный оператор:
Console.WriteLine(remainder == 0 ? "Кратно" : $"Не кратно, остаток {remainder}");