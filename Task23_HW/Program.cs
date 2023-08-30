/* Внутри класса Answer напишите метод ShowCube,
который принимает на вход число (N) и выводит таблицу
кубов чисел от 1 до N (включительно) каждое на новой строке. */

void ShowCube(int number)
{
    int i = 1;
    while(i <= number)
    {
        Console.WriteLine($"{i, 3} -> {i*i*i, 5}");
        i++;
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowCube(n);