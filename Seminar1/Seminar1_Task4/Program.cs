// Задача 4: Напишите программу, которая
// принимает на вход три числа и выдаёт
// максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

System.Console.Write("Сколько чисел будем сравнивать?");

if (!int.TryParse(Console.ReadLine(), out int quantity))
{
  System.Console.WriteLine("Введите корректное количество");
}
else
{
  int[] numbers = new int[quantity];
  int max = 0;
  for (int i = 0; i < quantity; i++)
  {
    System.Console.Write($"{i + 1}: ");
    if (!int.TryParse(Console.ReadLine(), out numbers[i]))
    {
      System.Console.WriteLine("Это не целое число, сорян");
    }
    else
    {
      if (i == 0)
      {
        max = numbers[i];
      }
      else if (numbers[i] > max)
      {
        max = numbers[i];
      }
    }
  }
  System.Console.WriteLine($"Max = {max}");
}
