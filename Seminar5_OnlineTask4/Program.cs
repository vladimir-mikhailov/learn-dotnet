// **Задача 35:**Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2]-> 0

// [10, 11, 12, 13, 14]-> 5


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

int Count(int[] arr)
{
  int count = 0;
  foreach (int item in arr)
  {
    if ((item >= 10) && (item <= 99))
    {
      count++;
    }
  }
  return count;
}

void ShowArray()
{
  int[] newArr = GenerateArr(GetNumber("число элементов массива"), GetNumber("минимальное значение"), GetNumber(" максимальное значение"));
  Console.Clear();
  Console.WriteLine($"{string.Join(',', newArr)}");
  Console.WriteLine($"Количество нужных чисел: {Count(newArr)}");
}

ShowArray();
