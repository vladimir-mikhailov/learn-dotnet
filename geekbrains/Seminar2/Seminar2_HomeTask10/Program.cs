// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetNumber()
{
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    System.Console.WriteLine("Введите корректное целое число");
  }
  return number;
}

int GetSecondDigit(int number)
{
  return (number - (number / 100 * 100) - (number % 10)) / 10;
}

System.Console.Write("Введите трёхзначное число: ");
int a = GetNumber();

System.Console.WriteLine($"Второе число: {GetSecondDigit(a)}");
