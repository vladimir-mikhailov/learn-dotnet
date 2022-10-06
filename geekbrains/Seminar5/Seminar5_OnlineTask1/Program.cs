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

string GetSum(int[] arr)
{
  int positiveSum = 0, negativeSum = 0;

  foreach (var item in arr)
  {
    if (item > 0)
    {
      positiveSum += item;
    }
    else
    {
      negativeSum += item;
    }
  }
  return $"{positiveSum} {negativeSum}";
}

void ShowArray()
{
  Console.Clear();
  Console.WriteLine(GetSum(GenerateArr(GetNumber("число элементов массива"), GetNumber("минимальное значение"), GetNumber("Максимальное значение"))));
}

ShowArray();
