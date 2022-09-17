// **Задача 57:** Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }

// 0 встречается 2 раза

// 1 встречается 1 раз

// 2 встречается 1 раз

// 8 встречается 1 раз

// 9 встречается 3 раза


int[,] GetArray(int rows, int columns)
{
  int[,] result = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = rnd.Next(10);
    }
  }

  return result;
}

int[] GetDict(int number)
{
  int[] result = new int[number];
  Random rnd = new Random();

  for (int i = 0; i < number; i++)
  {
    result[i] = rnd.Next(10);
  }

  return result;
}

int GetFrequency(int num, int[,] arr)
{
  int rows = arr.GetLength(0);
  int cols = arr.GetLength(1);
  int result = 0;

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      if (arr[i, j] == num) result++;
    }
  }
  return result;
}

Dictionary<int, int> GetFrequencies(int[,] arr, int[] dict)
{
  int rows = arr.GetLength(0);
  int cols = arr.GetLength(1);
  Dictionary<int, int> resultDictionary = new Dictionary<int, int>();

  for (int i = 0; i < dict.Length; i++)
  {
    if (!resultDictionary.ContainsKey(dict[i]))
    {
      resultDictionary.Add(dict[i], GetFrequency(dict[i], arr));
    }
  }

  return resultDictionary
    .OrderBy(obj => obj.Key)
    .ToDictionary(obj => obj.Key, obj => obj.Value);
}

void PrintArray(int[,] arr)
{
  int rows = arr.GetLength(0);
  int columns = arr.GetLength(1);

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      Console.Write($"{arr[i, j]} ");
    }
    Console.Write("\n");
  }
}

int[,] arr = GetArray(5, 5);
int[] dict = GetDict(7);
var freqDict = GetFrequencies(arr, dict);

Console.WriteLine();
PrintArray(arr);

Console.WriteLine();
Console.WriteLine($"Словарь для проверки: {string.Join(", ", dict)}");

Console.WriteLine();
foreach (var item in freqDict)
{
  Console.WriteLine($"\"{item.Key}\" встречается {item.Value} раз");
}
