/* Напишите программу, которая будет выдавать название дня
недели по заданному номеру */
Console.WriteLine("Введите число от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 & day < 8)
 Console.WriteLine("Хорошо!");
else
{
     Console.WriteLine("Число от 1 до 7!!!");
}
 if (day == 1)
{
     Console.WriteLine("Сегодня понедельник!");
}
  if (day == 2)
{
     Console.WriteLine("Сегодня вторник!");
}
   if (day == 3)
{
     Console.WriteLine("Сегодня среда!");
}
    if (day == 4)
{
     Console.WriteLine("Сегодня четверг!"); 
}
     if (day == 5)
{
     Console.WriteLine("Сегодня пятница!");
}
      if (day == 6)
{
     Console.WriteLine("Сегодня суббота!");
}
       if (day == 7)
{
     Console.WriteLine("Сегодня воскресенье!");
}
