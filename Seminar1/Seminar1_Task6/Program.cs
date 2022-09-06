// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число
// чётным (делится ли оно на два без остатка).

// 4->да
// - 3->нет
// 7->нет

Console.Clear();

System.Console.Write("Введите число, чтобы узнать, чётное оно или нет:");

if (!int.TryParse(Console.ReadLine(), out int number))
{
  System.Console.WriteLine("Введите корректное целое число");
}
else
{
  if (number % 2 == 0) { Console.WriteLine("Чётное"); }
  else { Console.WriteLine("Нечётное"); }
}
