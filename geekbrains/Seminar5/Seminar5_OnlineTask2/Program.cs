// **Задача 32:**Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int GetNumber(string what)
{
  Console.Write($"Введите {what}: ");
  if (!int.TryParse(Console.ReadLine(), out int number))
  {
    Console.WriteLine("Введите корректное целое число");
  }
  return number;
}

int[] GenerateArr(int arrLength, int minValue, int maxValue)
{
  int[] arr = new int[arrLength];

  Random rnd = new Random();

  for (int i = 0; i <= arr.Length - 1; i++)
  {
    arr[i] = rnd.Next(minValue, maxValue + 1);
  }

  return arr;
}

int[] Reverse(int[] arr)
{
  for (int i = 0; i <= arr.Length - 1; i++)
  {
    arr[i] *= -1;
  }
  return arr;
}

void ShowArray()
{
  Console.Clear();
  int[] newArr = GenerateArr(GetNumber("число элементов массива"), GetNumber("минимальное значение"), GetNumber("Максимальное значение"));
  Console.WriteLine(string.Join(',', newArr));
  Console.WriteLine(string.Join(',', Reverse(newArr)));
}

ShowArray();
