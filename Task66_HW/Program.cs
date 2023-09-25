/*  
Задайте значения M и N. Напишите программу, которая найдёт
сумму натуральных элементов в промежутке от M до N.
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNum1BiggerNum2(int num1, int num2) // 7,5; 7,6; 7,7
{
 if (num1 == num2) return num1; //7,7
 else return num2 + SumNum1BiggerNum2(num1, num2 + 1); //7,5  7,6
}

int SumNum2BiggerNum1(int num1, int num2) //5,7; 
{
 /* if (num2 == num1) return num2;
 else return num1 + SumNum1BiggerNum2(num1 + 1, num2);// так почему-то не работает */
 if (num2 == num1) return num2;
 else return num1 + SumNum1BiggerNum2(num2, num1 + 1);// а так работает, хотя что здесь происходит, так и не понял

}

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo)
 Console.WriteLine(SumNum1BiggerNum2(numberOne, numberTwo));
else
 Console.WriteLine(SumNum2BiggerNum1(numberOne, numberTwo));