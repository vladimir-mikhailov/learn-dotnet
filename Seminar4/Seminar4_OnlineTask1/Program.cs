// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5


int GetNumber()
{
  Console.Write("Введите число: ");
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    Console.WriteLine("Введите корректное целое число");
  }
  return number;
}

int CountDigits(int number)
{
  // Решение через деление на 10
  // int count = 0;

  // while (number > 0)
  // {
  //     number /= 10;
  //     count++;
  // }

  // return count;

  // Через логарифм
  return (int)Math.Log10(number) + 1;
}

Console.Clear();

Console.WriteLine($"В этом числе {CountDigits(GetNumber())} цифр");
