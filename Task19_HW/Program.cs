/* Ввод 5-ти значного числа
определить зеркало или нет */

bool FirstFifthSymbolOfDigit(int number)
{
 int FirstSymbol = number / 10000;
 int FifthSymbol = number % 10;
 if (FirstSymbol == FifthSymbol)
  return true;
 else return false;
}

bool SecondFourthSymbolOfDigit(int number)
{
 int SecondSymbol = (number / 1000) % 10;
 int FourthSymbol = (number % 100) / 10;
 if (SecondSymbol == FourthSymbol)
  return true;
 else return false;
}

bool CompareSymbolOfDigit(bool part1, bool part2)
{
 if (part1 == true && part2 == true)
  return true;
 else return false;
}

bool CheckOfDigit(int number)
{
 int Symbol = number / 10000;
 if (Symbol < 1 || Symbol > 9)
  return false;
 else return true;
}

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

bool Check = CheckOfDigit(num);

if (Check == true)
{
 bool result1 = FirstFifthSymbolOfDigit(num);
 bool result2 = SecondFourthSymbolOfDigit(num);
 bool ResultFinish = CompareSymbolOfDigit(result1, result2);
 Console.WriteLine(ResultFinish ? "Введенное число - палиндром" : "Введенное число не палиндром");
}
else
 {Console.WriteLine("Введенное число не пятизначное");}
