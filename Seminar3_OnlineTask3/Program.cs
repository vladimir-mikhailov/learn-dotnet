// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

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
  int[] powersArr = new int[number];

  for (int i = 0; i < number; i++)
  {
    powersArr[i] = Convert.ToInt32(Math.Pow(i + 1, 2));
  }

  return powersArr;
}

void ShowTable(int[] arr)
{
  System.Console.Write("1");

  for (int i = 1; i < arr.Length; i++)
  {
    System.Console.Write($" | {arr[i]}");
  }
}

ShowTable(getPowersTable(GetNumber()));
