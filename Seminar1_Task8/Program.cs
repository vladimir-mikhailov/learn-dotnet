// Задача 8: Напишите программу, которая
// на вход принимает число (N), а на выходе
// показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Введите число: ");

if (!int.TryParse(Console.ReadLine(), out int number))
{
  Console.WriteLine("Введите корректное целое число");
}
else
{
  for (int i = 2; i <= (number - 1); i = i + 2)
  {
    Console.Write($"{i} ");
  }
  if (number % 2 == 0) { Console.Write(number); }
}
