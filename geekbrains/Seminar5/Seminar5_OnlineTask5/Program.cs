// * *Задача 37:** Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6]-> 36 21


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

int[] MultiplyPairs(int[] arr)
{
  int size = arr.Length / 2;

  if (arr.Length % 2 == 1)
  {
    size++;
  }

  int[] result = new int[size];

  for (int i = 0; i < arr.Length / 2; i++)
  {
    result[i] = arr[i] * arr[arr.Length - i - 1];
  }

  if (arr.Length % 2 == 1)
  {
    result[size - 1] = arr[arr.Length / 2];
  }

  return result;
}

void ShowArray()
{
  Console.Clear();

  int[] newArr = GenerateArr(GetNumber("число элементов массива"), GetNumber("минимальное значение"), GetNumber(" максимальное значение"));

  Console.WriteLine($"[ {string.Join(", ", newArr)} ]");

  Console.WriteLine($"Массив перемноженных пар: {string.Join(", ", MultiplyPairs(newArr))}");
}

ShowArray();
