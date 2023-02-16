// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
if (! int.TryParse(Console.ReadLine(), out int date))
{
  Console.WriteLine("Вы ввели не цифру");
}
if (date > 7 || date < 0)
{
  Console.WriteLine("День недели введен не верно!");
  return;
}
if (date == 6 || date == 7)
{
  Console.WriteLine("Выходной!");
}
if (date < 6 )
{
  Console.WriteLine("Рабочий день :(");
}
  
