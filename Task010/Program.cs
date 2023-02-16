// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = new Random().Next(100, 1000); // [100-999]
// int result = (number / 100) * 10 + number % 10; 
// Для числа 478: (number / 100) * 10 = 4 * 10
// Console.WriteLine("Исходное число: " + number + " ; 1 и 3 цифра: " + result);

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int result = ((number % 100) - (number % 10)) / 10;
if (number >= 100 && number <= 999)
{
  Console.WriteLine($"Вторая цифра числа: {result}");
}
else
{
  Console.WriteLine("Введено некорректное число");
}