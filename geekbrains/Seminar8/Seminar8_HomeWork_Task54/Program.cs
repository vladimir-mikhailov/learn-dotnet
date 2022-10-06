// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

int[,] SortArrayRowsByDescending(int[,] arr)
{
  int rows = arr.GetLength(0);
  int columns = arr.GetLength(1);

  for (int i = 0; i < rows; i++)
  {
    for (int k = 0; k < columns; k++)
    {
      // GetMaxIndexes
      int max = arr[i, k];
      int maxElemIndex = k;

      for (int j = k; j < columns; j++)
      {
        if (arr[i, j] > max)
        {
          max = arr[i, j];
          maxElemIndex = j;
        }
      }

      // Swap
      int temp;

      if (maxElemIndex != k)
      {
        temp = arr[i, k];
        arr[i, k] = arr[i, maxElemIndex];
        arr[i, maxElemIndex] = temp;
      }
    }
  }

  return arr;
}

int[,] arr = GetArray(5, 6);
Console.WriteLine();
Console.WriteLine("Исходный массив:\n");
PrintArray(arr);

Console.WriteLine();
Console.WriteLine("Отсортированный массив:\n");
PrintArray(SortArrayRowsByDescending(arr));
Console.WriteLine();
