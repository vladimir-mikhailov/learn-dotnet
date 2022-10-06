// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int GetNumber()
{
  System.Console.Write("Введите число: ");
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    System.Console.WriteLine("Введите корректное целое число");
  }
  return number;
}

int[] getPowersTable(int number)
{
  int length = Math.Abs(number);

  int[] powersArr = new int[length];

  for (int i = 0; i < length; i++)
  {
    powersArr[i] = (number < 0) ? -1 * Convert.ToInt32(Math.Pow(i + 1, 3)) : Convert.ToInt32(Math.Pow(i + 1, 3));
  }

  return powersArr;
}

void ShowTable(int[] arr)
{
  System.Console.Write("Кубы: ");
  for (int i = 0; i < arr.Length; i++)
  {
    System.Console.Write($"{arr[i]} ");
  }
}

Console.Clear();
ShowTable(getPowersTable(GetNumber()));
