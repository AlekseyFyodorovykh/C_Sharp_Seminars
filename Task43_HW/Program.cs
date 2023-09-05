/* Задача 43: Напишите программу, которая найдёт точку пересечения
двух прямых, заданных уравнениями y = k1 * x + b1,
y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double IntersectionOfLinesY(double coeffK1, double coeffB1, double coeffK2, double coeffB2)
{
 double resultY = (coeffB2 * coeffK1 - coeffK2 * coeffB1) / (coeffK1 - coeffK2);
 return resultY;
}

double IntersectionOfLinesX(double resultY, double coeffB1, double coeffK1)
{
 double resultX = (resultY - coeffB1) / (coeffK1);
 return resultX;
}


Console.Write("Введите значение коэффициента k1, k1=");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение коэффициента b1, b1=");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение коэффициента k2, k2=");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение коэффициента b2, b1=");
double b2 = Convert.ToDouble(Console.ReadLine());

double intersectionOfLinesY = IntersectionOfLinesY(k1, b1, k2, b2);
double intersectionOfLinesX = IntersectionOfLinesX(intersectionOfLinesY, b1, k1);
Console.WriteLine($"Координаты точки пересечения прямых: X={intersectionOfLinesX}; Y={intersectionOfLinesY}");
