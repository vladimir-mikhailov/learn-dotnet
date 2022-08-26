// Задача 13: Напишите программу, которая
// выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int GetNumber()
{
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    System.Console.WriteLine("Введите корректное целое число");
  }
  return number;
}

bool CheckIf3rdDigitPresent(int number) => number / 100 > 0;

System.Console.Write("Введите трёхзначное число: ");
int num = GetNumber();

if (!CheckIf3rdDigitPresent(num)) System.Console.WriteLine("Третьей цифры нет");
else System.Console.WriteLine($"Третья цифра: {num % 10}");
