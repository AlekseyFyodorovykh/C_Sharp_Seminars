/* Внутри класса Answer напишите метод DistanceBetweenPoints,
который принимает на вход координаты двух точек pointA и pointB
в виде массива целых чисел, и возвращает расстояние между ними
в 3D пространстве.

A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double DistanceBetweenPoints(int xA, int yA, int zA, int xB, int yB, int zB)
{
 return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
}

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordinateA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoordinateB = Convert.ToInt32(Console.ReadLine());

double result = DistanceBetweenPoints(xCoordinateA, yCoordinateA, zCoordinateA, xCoordinateB, yCoordinateB, zCoordinateB);
Console.WriteLine($"{Math.Round(result, 2, MidpointRounding.ToZero)}");