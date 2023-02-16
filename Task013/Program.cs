// Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного 
// числа или сообщает, что третьей цифры нет.
// 78 -> третьей цифры нет
// 3267900 -> 6
// ДОП: цифра третья может быть как с левой стороны, так и с правой

Console.WriteLine("Введите число: ");
if (! int.TryParse(Console.ReadLine(), out int number))
    {
        Console.WriteLine("Вы ввели не число");
    }
//int number = Convert.ToInt32(Console.ReadLine());
int resultRight = ((number % 100000) - (number % 10000)) / 10000;
int resultLeft = ((number % 1000) - (number % 100)) / 100;
if (number >= 1000000 && number <= 9999999)
{
  Console.WriteLine($"Третья цифра с начала числа: {resultRight}, а третья цифра с конца числа {resultLeft}");
}
if (number >= 1 && number <100)
{
  Console.WriteLine("Третьей цифры нет");
}
if (number > 9999999)
{
  Console.WriteLine("Введено некорректное число");
}